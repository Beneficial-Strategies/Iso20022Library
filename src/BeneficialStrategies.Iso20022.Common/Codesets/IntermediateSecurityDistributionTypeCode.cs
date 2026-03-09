// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example &quot;exchange offer&quot;, &quot;capital reorganisation&quot; or &quot;funds separation&quot;.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_aaj4Y9p-Ed-ak6NoX_4Aeg_343425877")]
[Description(@"Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example ""exchange offer"", ""capital reorganisation"" or ""funds separation"".")]
[Derivations(typeof(IntermediateSecurityDistributionType3Code),typeof(IntermediateSecurityDistributionType1Code),typeof(IntermediateSecurityDistributionType2Code),typeof(IntermediateSecurityDistributionType5Code),typeof(IntermediateSecurityDistributionType4Code))]
public enum IntermediateSecurityDistributionTypeCode
{
    /// <summary>
    /// Distribution of reverser rights.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_aaj4ZNp-Ed-ak6NoX_4Aeg_599238283")]
    [Description(@"Distribution of reverser rights.")]
    ReverseRights,
    
    /// <summary>
    /// Distribution of bonus rights.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_aatpYNp-Ed-ak6NoX_4Aeg_599238313")]
    [Description(@"Distribution of bonus rights.")]
    BonusRights,
    
    /// <summary>
    /// Distribution of dividend reinvestment securities.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_aatpYdp-Ed-ak6NoX_4Aeg_599238344")]
    [Description(@"Distribution of dividend reinvestment securities.")]
    DividendReinvestment,
    
    /// <summary>
    /// Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_aatpYtp-Ed-ak6NoX_4Aeg_1890530937")]
    [Description(@"Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.")]
    CashDividend,
    
    /// <summary>
    /// Distribution of dividend option.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_aatpY9p-Ed-ak6NoX_4Aeg_599238374")]
    [Description(@"Distribution of dividend option.")]
    DividendOption,
    
    /// <summary>
    /// Distribution of subscription rights.
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_aatpZNp-Ed-ak6NoX_4Aeg_599238405")]
    [Description(@"Distribution of subscription rights.")]
    SubscriptionRights,
    
    /// <summary>
    /// Distribution of open offer rights.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_aatpZdp-Ed-ak6NoX_4Aeg_599238436")]
    [Description(@"Distribution of open offer rights.")]
    OpenOfferRights,
    
    /// <summary>
    /// Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_aatpZtp-Ed-ak6NoX_4Aeg_1519065678")]
    [Description(@"Dividend or interest paid in the form of scrip.")]
    ScripDividendOrPayment,
    
    /// <summary>
    /// Dividend paid to shareholders in the form of shares of stock.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_aatpZ9p-Ed-ak6NoX_4Aeg_2063022398")]
    [Description(@"Dividend paid to shareholders in the form of shares of stock.")]
    StockDividend,
    
    /// <summary>
    /// Interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_aatpaNp-Ed-ak6NoX_4Aeg_2127668527")]
    [Description(@"Interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment,
    
    /// <summary>
    /// A distribution of cash, assets or both.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_aatpadp-Ed-ak6NoX_4Aeg_-1905945270")]
    [Description(@"A distribution of cash, assets or both.")]
    LiquidationDividendOrPayment,
    
    /// <summary>
    /// A distribution of subsidiary stock to the shareholders.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_aa3aYNp-Ed-ak6NoX_4Aeg_-1793274673")]
    [Description(@"A distribution of subsidiary stock to the shareholders.")]
    SpinOff,
    
    /// <summary>
    /// Also known as change in nominal value or subdivision.|Increase in a corporation&apos;s number of outstanding equities without any change in the shareholder&apos;s equity or the aggregate market value at the time of the split. Equity price and nominal value are reduced accordingly.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_aa3aYdp-Ed-ak6NoX_4Aeg_1275578173")]
    [Description(@"Also known as change in nominal value or subdivision.|Increase in a corporation's number of outstanding equities without any change in the shareholder's equity or the aggregate market value at the time of the split. Equity price and nominal value are reduced accordingly.")]
    StockSplit,
    
    /// <summary>
    /// Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example &quot;exchange offer&quot;, &quot;capital reorganisation&quot; or &quot;funds separation&quot;.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_Qc9AsOAZEd-D2OAFXdoRmA")]
    [Description(@"Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example ""exchange offer"", ""capital reorganisation"" or ""funds separation"".")]
    Exchange,
    
    /// <summary>
    /// Exchange of outstanding securities, initiated by the issuer which may include options, as the result of two or more companies combining assets, that is, an external, third party company. Cash payments may accompany share exchange.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("_lL4c5_mXEeCobuMakDuHLg")]
    [Description(@"Exchange of outstanding securities, initiated by the issuer which may include options, as the result of two or more companies combining assets, that is, an external, third party company. Cash payments may accompany share exchange.")]
    Merger,
    
}
