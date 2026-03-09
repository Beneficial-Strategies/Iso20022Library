// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the type of intermediate security distribution.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_-q_4AQCcEeGiE5oKUBl5wQ")]
[Description(@"Specifies the type of intermediate security distribution.")]
[DerivedFrom(typeof(IntermediateSecurityDistributionTypeCode))]
public enum IntermediateSecurityDistributionType5Code
{
    /// <summary>
    /// Distribution of reverser rights.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_-q_4BwCcEeGiE5oKUBl5wQ")]
    [Description(@"Distribution of reverser rights.")]
    ReverseRights = IntermediateSecurityDistributionTypeCode.ReverseRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of dividend reinvestment securities.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_-q_4CwCcEeGiE5oKUBl5wQ")]
    [Description(@"Distribution of dividend reinvestment securities.")]
    DividendReinvestment = IntermediateSecurityDistributionTypeCode.DividendReinvestment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_-rJpAgCcEeGiE5oKUBl5wQ")]
    [Description(@"Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.")]
    CashDividend = IntermediateSecurityDistributionTypeCode.CashDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of dividend option.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_-rJpBgCcEeGiE5oKUBl5wQ")]
    [Description(@"Distribution of dividend option.")]
    DividendOption = IntermediateSecurityDistributionTypeCode.DividendOption, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of subscription rights.
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_-rJpCgCcEeGiE5oKUBl5wQ")]
    [Description(@"Distribution of subscription rights.")]
    SubscriptionRights = IntermediateSecurityDistributionTypeCode.SubscriptionRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of open offer rights.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_-rJpDgCcEeGiE5oKUBl5wQ")]
    [Description(@"Distribution of open offer rights.")]
    OpenOfferRights = IntermediateSecurityDistributionTypeCode.OpenOfferRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_-rJpEgCcEeGiE5oKUBl5wQ")]
    [Description(@"Dividend or interest paid in the form of scrip.")]
    ScripDividendOrPayment = IntermediateSecurityDistributionTypeCode.ScripDividendOrPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Dividend paid to shareholders in the form of shares of stock.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_-rJpFgCcEeGiE5oKUBl5wQ")]
    [Description(@"Dividend paid to shareholders in the form of shares of stock.")]
    StockDividend = IntermediateSecurityDistributionTypeCode.StockDividend, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_-rJpGgCcEeGiE5oKUBl5wQ")]
    [Description(@"Interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment = IntermediateSecurityDistributionTypeCode.InterestPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A distribution of cash, assets or both.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_-rJpHgCcEeGiE5oKUBl5wQ")]
    [Description(@"A distribution of cash, assets or both.")]
    LiquidationDividendOrPayment = IntermediateSecurityDistributionTypeCode.LiquidationDividendOrPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// A distribution of subsidiary stock to the shareholders.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_-rJpIgCcEeGiE5oKUBl5wQ")]
    [Description(@"A distribution of subsidiary stock to the shareholders.")]
    SpinOff = IntermediateSecurityDistributionTypeCode.SpinOff, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Also known as change in nominal value or subdivision.|Increase in a corporation&apos;s number of outstanding equities without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Equity price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_-rJpJgCcEeGiE5oKUBl5wQ")]
    [Description(@"Also known as change in nominal value or subdivision.|Increase in a corporation's number of outstanding equities without any change in the shareholder's equity or the aggregate market value at the time of the split. Equity price and nominal value are reduced accordingly.")]
    StockSplit = IntermediateSecurityDistributionTypeCode.StockSplit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Distribution of bonus rights.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_-rJpKgCcEeGiE5oKUBl5wQ")]
    [Description(@"Distribution of bonus rights.")]
    BonusRights = IntermediateSecurityDistributionTypeCode.BonusRights, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example &quot;exchange offer&quot;, &quot;capital reorganisation&quot; or &quot;funds separation&quot;.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_-rJpLgCcEeGiE5oKUBl5wQ")]
    [Description(@"Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example ""exchange offer"", ""capital reorganisation"" or ""funds separation"".")]
    Exchange = IntermediateSecurityDistributionTypeCode.Exchange, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Exchange of outstanding securities, initiated by the issuer which may include options, as the result of two or more companies combining assets, that is, an external, third party company. Cash payments may accompany share exchange.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("__QGwPgCcEeGiE5oKUBl5wQ")]
    [Description(@"Exchange of outstanding securities, initiated by the issuer which may include options, as the result of two or more companies combining assets, that is, an external, third party company. Cash payments may accompany share exchange.")]
    Merger = IntermediateSecurityDistributionTypeCode.Merger, // same ordinal as derivation source for type conversions
    
}
