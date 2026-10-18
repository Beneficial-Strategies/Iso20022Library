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
[IsoId("_ChM0kKQ4EfCieoAD4BflNw")]
[Description(@"Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example ""exchange offer"", ""capital reorganisation"" or ""funds separation"".")]
[Derivations(typeof(IntermediateSecurityDistributionType6Code), typeof(IntermediateSecurityDistributionType7Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<IntermediateSecurityDistributionTypeV2Code>))]
public enum IntermediateSecurityDistributionTypeV2Code
{
    /// <summary>
    /// Offer to existing holders by the issuing company to repurchase its own securities.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_ChNbm6Q4EfCieoAD4BflNw")]
    [Description(@"Offer to existing holders by the issuing company to repurchase its own securities. The objective of the offer is to reduce the number of outstanding securities.")]
    ReverseRights,

    /// <summary>
    /// Bonus or capitalisation issue.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_ChNbmqQ4EfCieoAD4BflNw")]
    [Description(@"Bonus or capitalisation issue. Security holders receive additional assets free of payment from the issuer, in proportion to their holding.")]
    BonusRights,

    /// <summary>
    /// Dividend payment where holders can keep cash or have the cash reinvested in the market by the issuer into additional shares in the issuing company.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_ChNbnKQ4EfCieoAD4BflNw")]
    [Description(@"Dividend payment where holders can keep cash or have the cash reinvested in the market by the issuer into additional shares in the issuing company. To be distinguished from DVOP as the company invests the dividend in the market rather than creating new share capital in exchange for the dividend.")]
    DividendReinvestment,

    /// <summary>
    /// Distribution of cash to shareholders, in proportion to their equity holding.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_ChNblKQ4EfCieoAD4BflNw")]
    [Description(@"Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.")]
    CashDividend,

    /// <summary>
    /// Distribution of dividend option.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_ChM0kaQ4EfCieoAD4BflNw")]
    [Description(@"Distribution of dividend option.")]
    DividendOption,

    /// <summary>
    /// Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_ChM0kqQ4EfCieoAD4BflNw")]
    [Description(@"Dividend or interest paid in the form of scrip.")]
    ScripDividendOrPayment,

    /// <summary>
    /// Dividend paid to shareholders in the form of equities of the issuing corporation.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_ChNbkqQ4EfCieoAD4BflNw")]
    [Description(@"Dividend paid to shareholders in the form of equities of the issuing corporation.")]
    StockDividend,

    /// <summary>
    /// Exchange of holdings for other securities and/or cash.
    /// Encoded/decoded by serializers as &quot;EXOF&quot;.
    /// </summary>
    [EnumMember(Value = "EXOF")]
    [IsoId("_ChNbl6Q4EfCieoAD4BflNw")]
    [Description(@"Exchange of holdings for other securities and/or cash. The exchange can be either mandatory or voluntary involving the exchange of outstanding securities for different securities and/or cash. For example ""exchange offer"", ""capital reorganisation"" or ""funds separation"".")]
    Exchange,

    /// <summary>
    /// Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution (RHDI).
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_ChNbkKQ4EfCieoAD4BflNw")]
    [Description(@"Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution (RHDI). This code is used for the second event, when an intermediate securities' issue (rights/coupons) is composed of two events, the first event being the distribution of intermediate securities.")]
    SubscriptionRights,

    /// <summary>
    /// Interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_ChNbk6Q4EfCieoAD4BflNw")]
    [Description(@"Interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment,

    /// <summary>
    /// Distribution of cash, assets or both.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_ChNbkaQ4EfCieoAD4BflNw")]
    [Description(@"Distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.")]
    LiquidationDividendOrPayment,

    /// <summary>
    /// Exchange of outstanding securities, initiated by the issuer which may include options, as the result of two or more companies combining assets.
    /// Encoded/decoded by serializers as &quot;MRGR&quot;.
    /// </summary>
    [EnumMember(Value = "MRGR")]
    [IsoId("_ChNbmKQ4EfCieoAD4BflNw")]
    [Description(@"Exchange of outstanding securities, initiated by the issuer which may include options, as the result of two or more companies combining assets, that is, an external, third party company. Cash payments may accompany share exchange.")]
    Merger,

    /// <summary>
    /// Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_ChNblaQ4EfCieoAD4BflNw")]
    [Description(@"Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders.")]
    OpenOfferRights,

    /// <summary>
    /// Distribution of subsidiary stock to the shareholders.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_ChNblqQ4EfCieoAD4BflNw")]
    [Description(@"Distribution of subsidiary stock to the shareholders.")]
    SpinOff,

    /// <summary>
    /// Increase in a corporation's number of outstanding equities without any change in the shareholder's equity or the aggregate market value at the time of the split.
    /// Encoded/decoded by serializers as &quot;SPLF&quot;.
    /// </summary>
    [EnumMember(Value = "SPLF")]
    [IsoId("_ChNbmaQ4EfCieoAD4BflNw")]
    [Description(@"Also known as change in nominal value or subdivision. Increase in a corporation's number of outstanding equities without any change in the shareholder's equity or the aggregate market value at the time of the split. Equity price and nominal value are reduced accordingly.")]
    StockSplit,

    /// <summary>
    /// Intermediate securities are distributed before the use of them has been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_PnfQIKRKEfC9EJoPPbbyNQ")]
    [Description(@"Intermediate securities are distributed before the use of them has been established.")]
    Unknown,
}
