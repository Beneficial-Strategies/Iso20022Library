// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of intermediate security distribution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aZ-Ch9p-Ed-ak6NoX_4Aeg_1639683801")]
[Description(@"Specifies the type of intermediate security distribution.")]
[DerivedFrom(typeof(IntermediateSecurityDistributionTypeCode))]
public enum IntermediateSecurityDistributionType1Code
{
    /// <summary>
    /// Distribution of reverser rights.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_aZ-CiNp-Ed-ak6NoX_4Aeg_1639683803")]
    [Description(@"Distribution of reverser rights.")]
    ReverseRights = IntermediateSecurityDistributionTypeCode.ReverseRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of bonus rights.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_aaHMcNp-Ed-ak6NoX_4Aeg_1639683831")]
    [Description(@"Distribution of bonus rights.")]
    BonusRights = IntermediateSecurityDistributionTypeCode.BonusRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of dividend reinvestment securities.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_aaHMcdp-Ed-ak6NoX_4Aeg_1639683832")]
    [Description(@"Distribution of dividend reinvestment securities.")]
    DividendReinvestment = IntermediateSecurityDistributionTypeCode.DividendReinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_aaHMctp-Ed-ak6NoX_4Aeg_1639683862")]
    [Description(
        @"Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency."
    )]
    CashDividend = IntermediateSecurityDistributionTypeCode.CashDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of dividend option.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_aaHMc9p-Ed-ak6NoX_4Aeg_1639683863")]
    [Description(@"Distribution of dividend option.")]
    DividendOption = IntermediateSecurityDistributionTypeCode.DividendOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of subscription rights.
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_aaHMdNp-Ed-ak6NoX_4Aeg_1639683864")]
    [Description(@"Distribution of subscription rights.")]
    SubscriptionRights = IntermediateSecurityDistributionTypeCode.SubscriptionRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of open offer rights.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_aaHMddp-Ed-ak6NoX_4Aeg_1639683885")]
    [Description(@"Distribution of open offer rights.")]
    OpenOfferRights = IntermediateSecurityDistributionTypeCode.OpenOfferRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_aaHMdtp-Ed-ak6NoX_4Aeg_1639683893")]
    [Description(@"Dividend or interest paid in the form of scrip.")]
    ScripDividendOrPayment = IntermediateSecurityDistributionTypeCode.ScripDividendOrPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend paid to shareholders in the form of shares of stock.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_aaHMd9p-Ed-ak6NoX_4Aeg_1639683894")]
    [Description(@"Dividend paid to shareholders in the form of shares of stock.")]
    StockDividend = IntermediateSecurityDistributionTypeCode.StockDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_aaHMeNp-Ed-ak6NoX_4Aeg_1639684133")]
    [Description(@"Interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment = IntermediateSecurityDistributionTypeCode.InterestPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A distribution of cash, assets or both.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_aaHMedp-Ed-ak6NoX_4Aeg_1639684141")]
    [Description(@"A distribution of cash, assets or both.")]
    LiquidationDividendOrPayment =
        IntermediateSecurityDistributionTypeCode.LiquidationDividendOrPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A distribution of subsidiary stock to the shareholders.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_aaQ9cNp-Ed-ak6NoX_4Aeg_1639684164")]
    [Description(@"A distribution of subsidiary stock to the shareholders.")]
    SpinOff = IntermediateSecurityDistributionTypeCode.SpinOff, // same ordinal as derivation source for type conversions
}
