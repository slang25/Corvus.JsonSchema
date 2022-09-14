@draft6

Feature: minProperties draft6
    In order to use json-schema
    As a developer
    I want to support minProperties in draft6

Scenario Outline: minProperties validation
/* Schema: 
{"minProperties": 1}
*/
    Given the input JSON file "minProperties.json"
    And the schema at "#/0/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/000/tests/000/data | true  | longer is valid                                                                  |
        | #/000/tests/001/data | true  | exact length is valid                                                            |
        | #/000/tests/002/data | false | too short is invalid                                                             |
        | #/000/tests/003/data | true  | ignores arrays                                                                   |
        | #/000/tests/004/data | true  | ignores strings                                                                  |
        | #/000/tests/005/data | true  | ignores other non-objects                                                        |

Scenario Outline: minProperties validation with a decimal
/* Schema: 
{"minProperties": 1.0}
*/
    Given the input JSON file "minProperties.json"
    And the schema at "#/1/schema"
    And the input data at "<inputDataReference>"
    And I generate a type for the schema
    And I construct an instance of the schema type from the data
    When I validate the instance
    Then the result will be <valid>

    Examples:
        | inputDataReference   | valid | description                                                                      |
        | #/001/tests/000/data | true  | longer is valid                                                                  |
        | #/001/tests/001/data | false | too short is invalid                                                             |
