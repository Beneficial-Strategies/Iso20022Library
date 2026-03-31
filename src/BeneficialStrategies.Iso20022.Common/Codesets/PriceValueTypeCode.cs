// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Price will not be paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aJunEtp-Ed-ak6NoX_4Aeg_-1411699432")]
[Description(@"Price will not be paid.")]
[Derivations(
    typeof(PriceValueType4Code),
    typeof(PriceValueType7Code),
    typeof(PriceValueType5Code),
    typeof(PriceRateType3Code),
    typeof(CommissionValueType1Code),
    typeof(PriceValueType8Code),
    typeof(PriceValueType3Code),
    typeof(PriceValueType12Code),
    typeof(PriceValueType9Code),
    typeof(PriceValueType2Code),
    typeof(PriceValueType1Code),
    typeof(PriceValueType10Code),
    typeof(PriceValueType6Code),
    typeof(PriceValueType13Code)
)]
public enum PriceValueTypeCode
{
    /// <summary>
    /// Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100.
    /// Encoded/decoded by serializers as &quot;DISC&quot;.
    /// </summary>
    [EnumMember(Value = "DISC")]
    [IsoId("_aJunE9p-Ed-ak6NoX_4Aeg_-1109708880")]
    [Description(
        @"Price expressed as a number of percentage points below par, for example, a discount price of 2.0% equals a price of 98 when par is 100."
    )]
    Discount,

    /// <summary>
    /// Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_aJunFNp-Ed-ak6NoX_4Aeg_-1109708508")]
    [Description(
        @"Price expressed as a number of percentage points above par, for example, a premium price of 2.0% equals a price of 102 when par is 100."
    )]
    Premium,

    /// <summary>
    /// Price is the face amount.
    /// Encoded/decoded by serializers as &quot;PARV&quot;.
    /// </summary>
    [EnumMember(Value = "PARV")]
    [IsoId("_aJunFdp-Ed-ak6NoX_4Aeg_-1109708466")]
    [Description(@"Price is the face amount.")]
    Par,

    /// <summary>
    /// Price expressed as a yield.
    /// Encoded/decoded by serializers as &quot;YIEL&quot;.
    /// </summary>
    [EnumMember(Value = "YIEL")]
    [IsoId("_aJunFtp-Ed-ak6NoX_4Aeg_-384717835")]
    [Description(@"Price expressed as a yield.")]
    Yield,

    /// <summary>
    /// Difference between a market maker&apos;s bid and asked price.
    /// Encoded/decoded by serializers as &quot;SPRE&quot;.
    /// </summary>
    [EnumMember(Value = "SPRE")]
    [IsoId("_aJunF9p-Ed-ak6NoX_4Aeg_-368096287")]
    [Description(@"Difference between a market maker's bid and asked price.")]
    Spread,

    /// <summary>
    /// Price expressed per unit.
    /// Encoded/decoded by serializers as &quot;PEUN&quot;.
    /// </summary>
    [EnumMember(Value = "PEUN")]
    [IsoId("_aJunGNp-Ed-ak6NoX_4Aeg_-355167252")]
    [Description(@"Price expressed per unit.")]
    PerUnit,

    /// <summary>
    /// Price is expressed as absolute.
    /// Encoded/decoded by serializers as &quot;ABSO&quot;.
    /// </summary>
    [EnumMember(Value = "ABSO")]
    [IsoId("_aJ3xANp-Ed-ak6NoX_4Aeg_-340391326")]
    [Description(@"Price is expressed as absolute.")]
    Absolute,

    /// <summary>
    /// Price is expressed as Treasury Euro Dollar price.
    /// Encoded/decoded by serializers as &quot;TEDP&quot;.
    /// </summary>
    [EnumMember(Value = "TEDP")]
    [IsoId("_aJ3xAdp-Ed-ak6NoX_4Aeg_-327461440")]
    [Description(@"Price is expressed as Treasury Euro Dollar price.")]
    TEDPrice,

    /// <summary>
    /// Price is expressed as Treasury Euro Dollar yield.
    /// Encoded/decoded by serializers as &quot;TEDY&quot;.
    /// </summary>
    [EnumMember(Value = "TEDY")]
    [IsoId("_aJ3xAtp-Ed-ak6NoX_4Aeg_-314530723")]
    [Description(@"Price is expressed as Treasury Euro Dollar yield.")]
    TEDYield,

    /// <summary>
    /// Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).
    /// Encoded/decoded by serializers as &quot;FICT&quot;.
    /// </summary>
    [EnumMember(Value = "FICT")]
    [IsoId("_aJ3xA9p-Ed-ak6NoX_4Aeg_-299754506")]
    [Description(
        @"Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options)."
    )]
    FixedCabinetTrade,

    /// <summary>
    /// Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options).
    /// Encoded/decoded by serializers as &quot;VACT&quot;.
    /// </summary>
    [EnumMember(Value = "VACT")]
    [IsoId("_aJ3xBNp-Ed-ak6NoX_4Aeg_-270202753")]
    [Description(
        @"Cabinet trades are used to indicate prices that trade at a price lower than that available on an exchange and they can be fixed or variable (primarily used for listed futures and options)."
    )]
    VariableCabinetTrade,

    /// <summary>
    /// Price expressed as a percentage of par.
    /// Encoded/decoded by serializers as &quot;PRCT&quot;.
    /// </summary>
    [EnumMember(Value = "PRCT")]
    [IsoId("_aJ3xBdp-Ed-ak6NoX_4Aeg_1243136291")]
    [Description(@"Price expressed as a percentage of par.")]
    Percentage,

    /// <summary>
    /// Price is unknown by the sender or has not been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_aJ3xBtp-Ed-ak6NoX_4Aeg_-1205888519")]
    [Description(@"Price is unknown by the sender or has not been established.")]
    Unknown,

    /// <summary>
    /// Price has not been established.
    /// Encoded/decoded by serializers as &quot;OPEN&quot;.
    /// </summary>
    [EnumMember(Value = "OPEN")]
    [IsoId("_aJ3xB9p-Ed-ak6NoX_4Aeg_-1205888489")]
    [Description(@"Price has not been established.")]
    OpenDated,

    /// <summary>
    /// Price is not required to be specified by account owner.
    /// Encoded/decoded by serializers as &quot;UNSP&quot;.
    /// </summary>
    [EnumMember(Value = "UNSP")]
    [IsoId("_aJ3xCNp-Ed-ak6NoX_4Aeg_384904535")]
    [Description(@"Price is not required to be specified by account owner.")]
    Unspecified,

    /// <summary>
    /// Price to be specified by account owner.
    /// Encoded/decoded by serializers as &quot;TBSP&quot;.
    /// </summary>
    [EnumMember(Value = "TBSP")]
    [IsoId("_aJ3xCdp-Ed-ak6NoX_4Aeg_384904566")]
    [Description(@"Price to be specified by account owner.")]
    ToBeSpecified,

    /// <summary>
    /// Price expressed as a currency and amount per unit or per share.
    /// Encoded/decoded by serializers as &quot;ACTU&quot;.
    /// </summary>
    [EnumMember(Value = "ACTU")]
    [IsoId("_aJ3xCtp-Ed-ak6NoX_4Aeg_-1798325648")]
    [Description(@"Price expressed as a currency and amount per unit or per share.")]
    ActualAmount,

    /// <summary>
    /// Price will not be paid.
    /// Encoded/decoded by serializers as &quot;NILP&quot;.
    /// </summary>
    [EnumMember(Value = "NILP")]
    [IsoId("_XHAZ0OEJEd-udr336SN7mQ")]
    [Description(@"Price will not be paid.")]
    NilPayment,

    /// <summary>
    /// Price must be interpreted as a negative amount of currency per unit or per share.
    /// Encoded/decoded by serializers as &quot;NEGA&quot;.
    /// </summary>
    [EnumMember(Value = "NEGA")]
    [IsoId("_c76HsAycEeuG8M5giQ2e0w")]
    [Description(
        @"Price must be interpreted as a negative amount of currency per unit or per share."
    )]
    NegativeActualAmount,
}
