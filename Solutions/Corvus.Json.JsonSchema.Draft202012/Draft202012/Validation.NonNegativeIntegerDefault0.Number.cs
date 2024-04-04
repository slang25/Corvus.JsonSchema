//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
using System.Collections.Immutable;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Corvus.Json;
using Corvus.Json.Internal;

namespace Corvus.Json.JsonSchema.Draft202012;
public readonly partial struct Validation
{
    /// <summary>
    /// Generated from JSON Schema.
    /// </summary>
    public readonly partial struct NonNegativeIntegerDefault0 
#if NET8_0_OR_GREATER
: IJsonNumber<NonNegativeIntegerDefault0>,
  IAdditionOperators<NonNegativeIntegerDefault0, NonNegativeIntegerDefault0, NonNegativeIntegerDefault0>,
  ISubtractionOperators<NonNegativeIntegerDefault0, NonNegativeIntegerDefault0, NonNegativeIntegerDefault0>,
  IMultiplyOperators<NonNegativeIntegerDefault0, NonNegativeIntegerDefault0, NonNegativeIntegerDefault0>,
  IDivisionOperators<NonNegativeIntegerDefault0, NonNegativeIntegerDefault0, NonNegativeIntegerDefault0>,
  IIncrementOperators<NonNegativeIntegerDefault0>,
  IDecrementOperators<NonNegativeIntegerDefault0>
#else
    : IJsonNumber<NonNegativeIntegerDefault0>
#endif
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "NonNegativeIntegerDefault0"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to construct the instance.</param>
        public NonNegativeIntegerDefault0(in BinaryJsonNumber value)
        {
            this.jsonElementBacking = default;
            this.backing = Backing.Number;
            this.numberBacking = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "NonNegativeIntegerDefault0"/> struct.
        /// </summary>
        /// <param name = "value">The value from which to initialize the number.</param>
        public NonNegativeIntegerDefault0(double value) : this(new BinaryJsonNumber(value))
        {
        }

        /// <summary>
        /// Conversion from JsonNumber.
        /// </summary>
        /// <param name = "value">The value from which to convert.</param>
        public static implicit operator NonNegativeIntegerDefault0(JsonNumber value)
        {
            if (value.HasDotnetBacking && value.ValueKind == JsonValueKind.Number)
            {
                return new(value.AsBinaryJsonNumber);
            }

            return new(value.AsJsonElement);
        }

        /// <summary>
        /// Conversion to byte.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a byte.</exception>
        public static explicit operator byte (NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetByte();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<byte>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to decimal.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a decimal.</exception>
        public static explicit operator decimal (NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetDecimal();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<decimal>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to double.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a double.</exception>
        public static explicit operator double (NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetDouble();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<double>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to Int16.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an Int16.</exception>
        public static explicit operator short (NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetInt16();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<short>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to Int32.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an Int32.</exception>
        public static explicit operator int (NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetInt32();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<int>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to Int64.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an Int64.</exception>
        public static explicit operator long (NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetInt64();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<long>();
            }

            throw new InvalidOperationException();
        }

#if NET8_0_OR_GREATER
    /// <summary>
    /// Conversion to Int128.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <exception cref="InvalidOperationException">The value was not a number.</exception>
    /// <exception cref="FormatException">The value was not formatted as an Int64.</exception>
    public static explicit operator Int128(NonNegativeIntegerDefault0 value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.SafeGetInt128();
        }

        if ((value.backing & Backing.Number) != 0)
        {
            return value.numberBacking.CreateChecked<Int128>();
        }

        throw new InvalidOperationException();
    }
#endif
        /// <summary>
        /// Conversion to SByte.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an SByte.</exception>
        public static explicit operator sbyte (NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetSByte();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<sbyte>();
            }

            throw new InvalidOperationException();
        }

#if NET8_0_OR_GREATER
    /// <summary>
    /// Conversion to Half.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <exception cref="InvalidOperationException">The value was not a number.</exception>
    /// <exception cref="FormatException">The value was not formatted as a Single.</exception>
    public static explicit operator Half(NonNegativeIntegerDefault0 value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.SafeGetHalf();
        }

        if ((value.backing & Backing.Number) != 0)
        {
            return value.numberBacking.CreateChecked<Half>();
        }

        throw new InvalidOperationException();
    }
#endif
        /// <summary>
        /// Conversion to Single.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as a Single.</exception>
        public static explicit operator float (NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetSingle();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<float>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to UInt16.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an UInt16.</exception>
        public static explicit operator ushort (NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetUInt16();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<ushort>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to UInt32.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an UInt32.</exception>
        public static explicit operator uint (NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetUInt32();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<uint>();
            }

            throw new InvalidOperationException();
        }

        /// <summary>
        /// Conversion to UInt64.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        /// <exception cref = "InvalidOperationException">The value was not a number.</exception>
        /// <exception cref = "FormatException">The value was not formatted as an UInt64.</exception>
        public static explicit operator ulong (NonNegativeIntegerDefault0 value)
        {
            if ((value.backing & Backing.JsonElement) != 0)
            {
                return value.jsonElementBacking.SafeGetUInt64();
            }

            if ((value.backing & Backing.Number) != 0)
            {
                return value.numberBacking.CreateChecked<ulong>();
            }

            throw new InvalidOperationException();
        }

#if NET8_0_OR_GREATER
    /// <summary>
    /// Conversion to UInt128.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    /// <exception cref="InvalidOperationException">The value was not a number.</exception>
    /// <exception cref="FormatException">The value was not formatted as an UInt64.</exception>
    public static explicit operator UInt128(NonNegativeIntegerDefault0 value)
    {
        if ((value.backing & Backing.JsonElement) != 0)
        {
            return value.jsonElementBacking.SafeGetUInt128();
        }

        if ((value.backing & Backing.Number) != 0)
        {
            return value.numberBacking.CreateChecked<UInt128>();
        }

        throw new InvalidOperationException();
    }
#endif
        /// <summary>
        /// Conversion from decimal.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeIntegerDefault0(decimal value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from double.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeIntegerDefault0(double value)
        {
            return new(new BinaryJsonNumber(value));
        }

#if NET8_0_OR_GREATER
    /// <summary>
    /// Conversion from Half.
    /// </summary>
    /// <param name="value">The value to convert.</param>
    public static explicit operator NonNegativeIntegerDefault0(Half value)
    {
        return new(new BinaryJsonNumber(value));
    }
#endif
        /// <summary>
        /// Conversion from float.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeIntegerDefault0(float value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from byte.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeIntegerDefault0(byte value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from short.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeIntegerDefault0(short value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from int.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeIntegerDefault0(int value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from long.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeIntegerDefault0(long value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from sbyte.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeIntegerDefault0(sbyte value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from ushort.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeIntegerDefault0(ushort value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from uint.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeIntegerDefault0(uint value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Conversion from ulong.
        /// </summary>
        /// <param name = "value">The value to convert.</param>
        public static explicit operator NonNegativeIntegerDefault0(ulong value)
        {
            return new(new BinaryJsonNumber(value));
        }

        /// <summary>
        /// Less than operator.
        /// </summary>
        /// <param name = "left">The LHS of the comparison.</param>
        /// <param name = "right">The RHS of the comparison.</param>
        /// <returns><see langword="true"/> if the left is less than the right, otherwise <see langword="false"/>.</returns>
        public static bool operator <(in NonNegativeIntegerDefault0 left, in NonNegativeIntegerDefault0 right)
        {
            return left.IsNotNullOrUndefined() && right.IsNotNullOrUndefined() && Compare(left, right) < 0;
        }

        /// <summary>
        /// Greater than operator.
        /// </summary>
        /// <param name = "left">The LHS of the comparison.</param>
        /// <param name = "right">The RHS of the comparison.</param>
        /// <returns><see langword="true"/> if the left is greater than the right, otherwise <see langword="false"/>.</returns>
        public static bool operator>(in NonNegativeIntegerDefault0 left, in NonNegativeIntegerDefault0 right)
        {
            return left.IsNotNullOrUndefined() && right.IsNotNullOrUndefined() && Compare(left, right) > 0;
        }

        /// <summary>
        /// Less than operator.
        /// </summary>
        /// <param name = "left">The LHS of the comparison.</param>
        /// <param name = "right">The RHS of the comparison.</param>
        /// <returns><see langword="true"/> if the left is less than the right, otherwise <see langword="false"/>.</returns>
        public static bool operator <=(in NonNegativeIntegerDefault0 left, in NonNegativeIntegerDefault0 right)
        {
            return left.IsNotNullOrUndefined() && right.IsNotNullOrUndefined() && Compare(left, right) <= 0;
        }

        /// <summary>
        /// Greater than operator.
        /// </summary>
        /// <param name = "left">The LHS of the comparison.</param>
        /// <param name = "right">The RHS of the comparison.</param>
        /// <returns><see langword="true"/> if the left is greater than the right, otherwise <see langword="false"/>.</returns>
        public static bool operator >=(in NonNegativeIntegerDefault0 left, in NonNegativeIntegerDefault0 right)
        {
            return left.IsNotNullOrUndefined() && right.IsNotNullOrUndefined() && Compare(left, right) >= 0;
        }

        /// <summary>
        /// Adds two values together to compute their sum.
        /// </summary>
        /// <param name = "left">The left hand side.</param>
        /// <param name = "right">The right hand side.</param>
        /// <returns>The resulting value.</returns>
        public static NonNegativeIntegerDefault0 operator +(NonNegativeIntegerDefault0 left, NonNegativeIntegerDefault0 right)
        {
            return new(left.AsBinaryJsonNumber + right.AsBinaryJsonNumber);
        }

        /// <summary>
        /// Subtracts two values together to compute their difference.
        /// </summary>
        /// <param name = "left">The left hand side.</param>
        /// <param name = "right">The right hand side.</param>
        /// <returns>The resulting value.</returns>
        public static NonNegativeIntegerDefault0 operator -(NonNegativeIntegerDefault0 left, NonNegativeIntegerDefault0 right)
        {
            return new(left.AsBinaryJsonNumber - right.AsBinaryJsonNumber);
        }

        /// <summary>
        /// Multiplies two values together.
        /// </summary>
        /// <param name = "left">The left hand side.</param>
        /// <param name = "right">The right hand side.</param>
        /// <returns>The resulting value.</returns>
        public static NonNegativeIntegerDefault0 operator *(NonNegativeIntegerDefault0 left, NonNegativeIntegerDefault0 right)
        {
            return new(left.AsBinaryJsonNumber * right.AsBinaryJsonNumber);
        }

        /// <summary>
        /// Divides two values.
        /// </summary>
        /// <param name = "left">The left hand side.</param>
        /// <param name = "right">The right hand side.</param>
        /// <returns>The resulting value.</returns>
        public static NonNegativeIntegerDefault0 operator /(NonNegativeIntegerDefault0 left, NonNegativeIntegerDefault0 right)
        {
            return new(left.AsBinaryJsonNumber / right.AsBinaryJsonNumber);
        }

        /// <summary>
        /// Increments the value.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The resulting value.</returns>
        public static NonNegativeIntegerDefault0 operator ++(NonNegativeIntegerDefault0 value)
        {
            BinaryJsonNumber num = value.AsBinaryJsonNumber;
            return new(num++);
        }

        /// <summary>
        /// Decrements the value.
        /// </summary>
        /// <param name = "value">The value.</param>
        /// <returns>The resulting value.</returns>
        public static NonNegativeIntegerDefault0 operator --(NonNegativeIntegerDefault0 value)
        {
            BinaryJsonNumber num = value.AsBinaryJsonNumber;
            return new(num--);
        }

        /// <summary>
        /// Compare with another number.
        /// </summary>
        /// <param name = "lhs">The lhs of the comparison.</param>
        /// <param name = "rhs">The rhs of the comparison.</param>
        /// <returns>0 if the numbers are equal, -1 if the lhs is less than the rhs, and 1 if the lhs is greater than the rhs.</returns>
        public static int Compare(in NonNegativeIntegerDefault0 lhs, in NonNegativeIntegerDefault0 rhs)
        {
            if (lhs.ValueKind != rhs.ValueKind)
            {
                // We can't be equal if we are not the same underlying type
                return lhs.IsNullOrUndefined() ? 1 : -1;
            }

            if (lhs.IsNull())
            {
                // Nulls are always equal
                return 0;
            }

            if (lhs.backing == Backing.Number && rhs.backing == Backing.Number)
            {
                return BinaryJsonNumber.Compare(lhs.numberBacking, rhs.numberBacking);
            }

            // After this point there is no need to check both value kinds because our first quick test verified that they were the same.
            // If either one is a Backing.Number or a JsonValueKind.Number then we know the rhs is compatible.
            if (lhs.backing == Backing.Number && rhs.backing == Backing.Number)
            {
                return BinaryJsonNumber.Compare(lhs.numberBacking, rhs.numberBacking);
            }

            if (lhs.backing == Backing.Number && rhs.backing == Backing.JsonElement)
            {
                return BinaryJsonNumber.Compare(lhs.numberBacking, rhs.jsonElementBacking);
            }

            if (lhs.backing == Backing.JsonElement && rhs.backing == Backing.Number)
            {
                return BinaryJsonNumber.Compare(lhs.jsonElementBacking, rhs.numberBacking);
            }

            if (lhs.backing == Backing.JsonElement && rhs.backing == Backing.JsonElement && rhs.jsonElementBacking.ValueKind == JsonValueKind.Number)
            {
                return JsonValueHelpers.NumericCompare(lhs.jsonElementBacking, rhs.jsonElementBacking);
            }

            throw new InvalidOperationException();
        }

        /// <inheritdoc/>
        public BinaryJsonNumber AsBinaryJsonNumber => this.HasDotnetBacking ? this.numberBacking : BinaryJsonNumber.FromJson(this.jsonElementBacking);
    }
}