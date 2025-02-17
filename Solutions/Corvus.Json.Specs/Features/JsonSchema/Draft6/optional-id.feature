@draft6

Feature: optional-id draft6
    In order to use json-schema
    As a developer
    I want to support optional-id in draft6

Scenario Outline: id inside an enum is not a real identifier
/* Schema: 
{
            "definitions": {
                "id_in_enum": {
                    "enum": [
                        {
                          "$id": "https://localhost:1234/id/my_identifier.json",
                          "type": "null"
                        }
                    ]
                },
                "real_id_in_schema": {
                    "$id": "https://localhost:1234/id/my_identifier.json",
                    "type": "string"
                },
                "zzz_id_in_const": {
                    "const": {
                        "$id": "https://localhost:1234/id/my_identifier.json",
                        "type": "null"
                    }
                }
            },
            "anyOf": [
                { "$ref": "#/definitions/id_in_enum" },
                { "$ref": "https://localhost:1234/id/my_identifier.json" }
            ]
        }
*/
    Given the input JSON file "optional/id.json"
    And the schema at "#/0/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        # { "$id": "https://localhost:1234/id/my_identifier.json", "type": "null" }
        | #/000/tests/000/data | true  | exact match to enum, and type matches                                            |
        # a string to match #/definitions/id_in_enum
        | #/000/tests/001/data | true  | match $ref to id                                                                 |
        # 1
        | #/000/tests/002/data | false | no match on enum or $ref to id                                                   |

Scenario Outline: non-schema object containing a plain-name $id property
/* Schema: 
{
            "definitions": {
                "const_not_anchor": {
                    "const": {
                        "$id": "#not_a_real_anchor"
                    }
                }
            },
            "oneOf": [
                {
                    "const": "skip not_a_real_anchor"
                },
                {
                    "allOf": [
                        {
                            "not": {
                                "const": "skip not_a_real_anchor"
                            }
                        },
                        {
                            "$ref": "#/definitions/const_not_anchor"
                        }
                    ]
                }
            ]
        }
*/
    Given the input JSON file "optional/id.json"
    And the schema at "#/1/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        # skip not_a_real_anchor
        | #/001/tests/000/data | true  | skip traversing definition for a valid result                                    |
        # 1
        | #/001/tests/001/data | false | const at const_not_anchor does not match                                         |

Scenario Outline: non-schema object containing an $id property
/* Schema: 
{
            "definitions": {
                "const_not_id": {
                    "const": {
                        "$id": "not_a_real_id"
                    }
                }
            },
            "oneOf": [
                {
                    "const":"skip not_a_real_id"
                },
                {
                    "allOf": [
                        {
                            "not": {
                                "const": "skip not_a_real_id"
                            }
                        },
                        {
                            "$ref": "#/definitions/const_not_id"
                        }
                    ]
                }
            ]
        }
*/
    Given the input JSON file "optional/id.json"
    And the schema at "#/2/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        # skip not_a_real_id
        | #/002/tests/000/data | true  | skip traversing definition for a valid result                                    |
        # 1
        | #/002/tests/001/data | false | const at const_not_id does not match                                             |
