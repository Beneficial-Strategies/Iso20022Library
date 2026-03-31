// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies a type of value of the price.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aJR7Jdp-Ed-ak6NoX_4Aeg_-611906034")]
[Description(@"Specifies a type of value of the price.")]
[DerivedFrom(typeof(PriceValueTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<PriceValueType3Code>))]
#endif
public enum PriceValueType3Code
{
    /// <summary>
    /// Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_aJR7Jtp-Ed-ak6NoX_4Aeg_-611906017")]
    [Description(
        @"Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100."
    )]
    Discount = PriceValueTypeCode.Discount, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_aJR7J9p-Ed-ak6NoX_4Aeg_-611906016")]
    [Description(
        @"Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100."
    )]
    Premium = PriceValueTypeCode.Premium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is the face amount.
    /// Encoded/decoded by serializers as &quot;PARV&quot;.
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("_aJR7KNp-Ed-ak6NoX_4Aeg_-611906015")]
    [Description(@"Price is the face amount.")]
    Par = PriceValueTypeCode.Par, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price expressed as a yield.
    /// Encoded/decoded by serializers as &quot;YIEL&quot;.
    /// </summary>
    [EnumMember(Value = "YIEL")]
    [IsoId("_aJbFENp-Ed-ak6NoX_4Aeg_1135725162")]
    [Description(@"Price expressed as a yield.")]
    Yield = PriceValueTypeCode.Yield, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Difference between a market maker&apos;s bid and asked price.
    /// Encoded/decoded by serializers as &quot;SPRE&quot;.
    /// </summary>
    [EnumMember(Value = "SPRE")]
    [IsoId("_aJbFEdp-Ed-ak6NoX_4Aeg_1135725179")]
    [Description(@"Difference between a market maker's bid and asked price.")]
    Spread = PriceValueTypeCode.Spread, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price expressed per unit.
    /// Encoded/decoded by serializers as &quot;PEUN&quot;.
    /// </summary>
    [EnumMember(Value = "PEUN")]
    [IsoId("_aJbFEtp-Ed-ak6NoX_4Aeg_1135725180")]
    [Description(@"Price expressed per unit.")]
    PerUnit = PriceValueTypeCode.PerUnit, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is expressed as absolute.
    /// Encoded/decoded by serializers as &quot;ABSO&quot;.
    /// </summary>
    [EnumMember(Value = "ABSO")]
    [IsoId("_aJbFE9p-Ed-ak6NoX_4Aeg_1135725445")]
    [Description(@"Price is expressed as absolute.")]
    Absolute = PriceValueTypeCode.Absolute, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is expressed as Treasury Euro Dollar price.
    /// Encoded/decoded by serializers as &quot;TEDP&quot;.
    /// </summary>
    [EnumMember(Value = "TEDP")]
    [IsoId("_aJbFFNp-Ed-ak6NoX_4Aeg_1135725446")]
    [Description(@"Price is expressed as Treasury Euro Dollar price.")]
    TEDPrice = PriceValueTypeCode.TEDPrice, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Price is expressed as Treasury Euro Dollar yield.
    /// Encoded/decoded by serializers as &quot;TEDY&quot;.
    /// </summary>
    [EnumMember(Value = "TEDY")]
    [IsoId("_aJbFFdp-Ed-ak6NoX_4Aeg_1135725470")]
    [Description(@"Price is expressed as Treasury Euro Dollar yield.")]
    TEDYield = PriceValueTypeCode.TEDYield, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).
    /// Encoded/decoded by serializers as &quot;FICT&quot;.
    /// </summary>
    [EnumMember(Value = "FICT")]
    [IsoId("_aJbFFtp-Ed-ak6NoX_4Aeg_1135725487")]
    [Description(
        @"Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options)."
    )]
    FixedCabinetTrade = PriceValueTypeCode.FixedCabinetTrade, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).
    /// Encoded/decoded by serializers as &quot;VACT&quot;.
    /// </summary>
    [EnumMember(Value = "VACT")]
    [IsoId("_aJbFF9p-Ed-ak6NoX_4Aeg_1135725488")]
    [Description(
        @"Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options)."
    )]
    VariableCabinetTrade = PriceValueTypeCode.VariableCabinetTrade, // same ordinal as derivation source for type conversions
}
