// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Price will not be paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_ETkqkAydEeuG8M5giQ2e0w")]
[Description(@"Price will not be paid.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
public enum PriceValueType12Code
{
    /// <summary>
    /// Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_HwDYgQydEeuG8M5giQ2e0w")]
    [Description(
        @"Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100."
    )]
    Discount = PriceValueTypeCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the face amount.
    /// Encoded/decoded by serializers as &quot;PARV&quot;.
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("_H7XQoQydEeuG8M5giQ2e0w")]
    [Description(@"Price is the face amount.")]
    Par = PriceValueTypeCode.Par, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_I1Yo4QydEeuG8M5giQ2e0w")]
    [Description(
        @"Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100."
    )]
    Premium = PriceValueTypeCode.Premium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price must be interpreted as a negative amount of currency per unit or per share.
    /// Encoded/decoded by serializers as &quot;NEGA&quot;.
    /// </summary>
    [EnumMember(Value = "NEGA")]
    [IsoId("_JUe_sQydEeuG8M5giQ2e0w")]
    [Description(
        @"Price must be interpreted as a negative amount of currency per unit or per share."
    )]
    NegativeActualAmount = PriceValueTypeCode.NegativeActualAmount, // same ordinal as derivation source for type conversions
}
