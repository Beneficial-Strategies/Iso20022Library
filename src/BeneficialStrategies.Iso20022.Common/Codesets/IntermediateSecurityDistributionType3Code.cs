// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of intermediate security distribution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aaQ9eNp-Ed-ak6NoX_4Aeg_920795156")]
[Description(@"Specifies the type of intermediate security distribution.")]
[DerivedFrom(typeof(IntermediateSecurityDistributionTypeCode))]
#if NET8_0_OR_GREATER // C# 12 Global type alias
[JsonConverter(typeof(JsonStringEnumConverter<IntermediateSecurityDistributionType3Code>))]
#endif
public enum IntermediateSecurityDistributionType3Code
{
    /// <summary>
    /// Distribution of reverser rights.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_aaaucNp-Ed-ak6NoX_4Aeg_920795158")]
    [Description(@"Distribution of reverser rights.")]
    ReverseRights = IntermediateSecurityDistributionTypeCode.ReverseRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of bonus rights.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_aaaucdp-Ed-ak6NoX_4Aeg_920795181")]
    [Description(@"Distribution of bonus rights.")]
    BonusRights = IntermediateSecurityDistributionTypeCode.BonusRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of dividend reinvestment securities.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_aaauctp-Ed-ak6NoX_4Aeg_920795198")]
    [Description(@"Distribution of dividend reinvestment securities.")]
    DividendReinvestment = IntermediateSecurityDistributionTypeCode.DividendReinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_aaauc9p-Ed-ak6NoX_4Aeg_921715300")]
    [Description(
        @"Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency."
    )]
    CashDividend = IntermediateSecurityDistributionTypeCode.CashDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of dividend option.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_aaaudNp-Ed-ak6NoX_4Aeg_921715308")]
    [Description(@"Distribution of dividend option.")]
    DividendOption = IntermediateSecurityDistributionTypeCode.DividendOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of subscription rights.
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_aaauddp-Ed-ak6NoX_4Aeg_921715420")]
    [Description(@"Distribution of subscription rights.")]
    SubscriptionRights = IntermediateSecurityDistributionTypeCode.SubscriptionRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of open offer rights.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_aaaudtp-Ed-ak6NoX_4Aeg_921715437")]
    [Description(@"Distribution of open offer rights.")]
    OpenOfferRights = IntermediateSecurityDistributionTypeCode.OpenOfferRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_aaaud9p-Ed-ak6NoX_4Aeg_921715455")]
    [Description(@"Dividend or interest paid in the form of scrip.")]
    ScripDividendOrPayment = IntermediateSecurityDistributionTypeCode.ScripDividendOrPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend paid to shareholders in the form of shares of stock.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_aaaueNp-Ed-ak6NoX_4Aeg_921715480")]
    [Description(@"Dividend paid to shareholders in the form of shares of stock.")]
    StockDividend = IntermediateSecurityDistributionTypeCode.StockDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_aaauedp-Ed-ak6NoX_4Aeg_921715497")]
    [Description(@"Interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment = IntermediateSecurityDistributionTypeCode.InterestPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A distribution of cash, assets or both.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_aaj4YNp-Ed-ak6NoX_4Aeg_921715515")]
    [Description(@"A distribution of cash, assets or both.")]
    LiquidationDividendOrPayment =
        IntermediateSecurityDistributionTypeCode.LiquidationDividendOrPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// A distribution of subsidiary stock to the shareholders.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_aaj4Ydp-Ed-ak6NoX_4Aeg_921715540")]
    [Description(@"A distribution of subsidiary stock to the shareholders.")]
    SpinOff = IntermediateSecurityDistributionTypeCode.SpinOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Also known as change in nominal value or subdivision.|Increase in a corporation&apos;s number of outstanding equities without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Equity price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_aaj4Ytp-Ed-ak6NoX_4Aeg_-929459719")]
    [Description(
        @"Also known as change in nominal value or subdivision.|Increase in a corporation's number of outstanding equities without any change in the shareholder's equity or the aggregate market value at the time of the split. Equity price and nominal value are reduced accordingly."
    )]
    StockSplit = IntermediateSecurityDistributionTypeCode.StockSplit, // same ordinal as derivation source for type conversions
}
