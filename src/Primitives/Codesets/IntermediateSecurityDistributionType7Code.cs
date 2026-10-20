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
[IsoId("_0NjiMaRXEfC9EJoPPbbyNQ")]
[Description(@"Specifies the type of intermediate security distribution.")]
[DerivedFrom(typeof(IntermediateSecurityDistributionTypeV2Code))]
[JsonConverter(typeof(Iso20022EnumJsonConverter<IntermediateSecurityDistributionType7Code>))]
public enum IntermediateSecurityDistributionType7Code
{
    /// <summary>
    /// Offer to existing holders by the issuing company to repurchase its own securities.
    /// Encoded/decoded by serializers as &quot;BIDS&quot;.
    /// </summary>
    [EnumMember(Value = "BIDS")]
    [IsoId("_AE_qQaRYEfC9EJoPPbbyNQ")]
    [Description(@"Offer to existing holders by the issuing company to repurchase its own securities. The objective of the offer is to reduce the number of outstanding securities.")]
    ReverseRights = IntermediateSecurityDistributionTypeV2Code.ReverseRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Bonus or capitalisation issue.
    /// Encoded/decoded by serializers as &quot;BONU&quot;.
    /// </summary>
    [EnumMember(Value = "BONU")]
    [IsoId("_3i67gaRXEfC9EJoPPbbyNQ")]
    [Description(@"Bonus or capitalisation issue. Security holders receive additional assets free of payment from the issuer, in proportion to their holding.")]
    BonusRights = IntermediateSecurityDistributionTypeV2Code.BonusRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend payment where holders can keep cash or have the cash reinvested in the market by the issuer into additional shares in the issuing company.
    /// Encoded/decoded by serializers as &quot;DRIP&quot;.
    /// </summary>
    [EnumMember(Value = "DRIP")]
    [IsoId("_5Wt0YaRXEfC9EJoPPbbyNQ")]
    [Description(@"Dividend payment where holders can keep cash or have the cash reinvested in the market by the issuer into additional shares in the issuing company. To be distinguished from DVOP as the company invests the dividend in the market rather than creating new share capital in exchange for the dividend.")]
    DividendReinvestment = IntermediateSecurityDistributionTypeV2Code.DividendReinvestment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of cash to shareholders, in proportion to their equity holding.
    /// Encoded/decoded by serializers as &quot;DVCA&quot;.
    /// </summary>
    [EnumMember(Value = "DVCA")]
    [IsoId("_5ESnoaRXEfC9EJoPPbbyNQ")]
    [Description(@"Distribution of cash to shareholders, in proportion to their equity holding. Ordinary dividends are recurring and regular. Shareholder must take cash and may be offered a choice of currency.")]
    CashDividend = IntermediateSecurityDistributionTypeV2Code.CashDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of dividend option.
    /// Encoded/decoded by serializers as &quot;DVOP&quot;.
    /// </summary>
    [EnumMember(Value = "DVOP")]
    [IsoId("_5OoPYaRXEfC9EJoPPbbyNQ")]
    [Description(@"Distribution of dividend option.")]
    DividendOption = IntermediateSecurityDistributionTypeV2Code.DividendOption, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend or interest paid in the form of scrip.
    /// Encoded/decoded by serializers as &quot;DVSC&quot;.
    /// </summary>
    [EnumMember(Value = "DVSC")]
    [IsoId("_Bd5W4aRYEfC9EJoPPbbyNQ")]
    [Description(@"Dividend or interest paid in the form of scrip.")]
    ScripDividendOrPayment = IntermediateSecurityDistributionTypeV2Code.ScripDividendOrPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Dividend paid to shareholders in the form of equities of the issuing corporation.
    /// Encoded/decoded by serializers as &quot;DVSE&quot;.
    /// </summary>
    [EnumMember(Value = "DVSE")]
    [IsoId("_FOD10aRYEfC9EJoPPbbyNQ")]
    [Description(@"Dividend paid to shareholders in the form of equities of the issuing corporation.")]
    StockDividend = IntermediateSecurityDistributionTypeV2Code.StockDividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution (RHDI).
    /// Encoded/decoded by serializers as &quot;EXRI&quot;.
    /// </summary>
    [EnumMember(Value = "EXRI")]
    [IsoId("_GvqygaRYEfC9EJoPPbbyNQ")]
    [Description(@"Call or exercise on nil paid securities or intermediate securities resulting from an intermediate securities distribution (RHDI). This code is used for the second event, when an intermediate securities' issue (rights/coupons) is composed of two events, the first event being the distribution of intermediate securities.")]
    SubscriptionRights = IntermediateSecurityDistributionTypeV2Code.SubscriptionRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Interest payment distributed to holders of an interest bearing asset.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_740kwaRXEfC9EJoPPbbyNQ")]
    [Description(@"Interest payment distributed to holders of an interest bearing asset.")]
    InterestPayment = IntermediateSecurityDistributionTypeV2Code.InterestPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of cash, assets or both.
    /// Encoded/decoded by serializers as &quot;LIQU&quot;.
    /// </summary>
    [EnumMember(Value = "LIQU")]
    [IsoId("_8-nvMaRXEfC9EJoPPbbyNQ")]
    [Description(@"Distribution of cash, assets or both. Debt may be paid in order of priority based on preferred claims to assets specified by the security.")]
    LiquidationDividendOrPayment = IntermediateSecurityDistributionTypeV2Code.LiquidationDividendOrPayment, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders.
    /// Encoded/decoded by serializers as &quot;PRIO&quot;.
    /// </summary>
    [EnumMember(Value = "PRIO")]
    [IsoId("_9re1MaRXEfC9EJoPPbbyNQ")]
    [Description(@"Form of open or public offer where, due to a limited amount of securities available, priority is given to existing shareholders.")]
    OpenOfferRights = IntermediateSecurityDistributionTypeV2Code.OpenOfferRights, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of subsidiary stock to the shareholders.
    /// Encoded/decoded by serializers as &quot;SOFF&quot;.
    /// </summary>
    [EnumMember(Value = "SOFF")]
    [IsoId("_FIBfQaRYEfC9EJoPPbbyNQ")]
    [Description(@"Distribution of subsidiary stock to the shareholders.")]
    SpinOff = IntermediateSecurityDistributionTypeV2Code.SpinOff, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Intermediate securities are distributed before the use of them has been established.
    /// Encoded/decoded by serializers as &quot;UKWN&quot;.
    /// </summary>
    [EnumMember(Value = "UKWN")]
    [IsoId("_0UBWr6RXEfC9EJoPPbbyNQ")]
    [Description(@"Intermediate securities are distributed before the use of them has been established.")]
    Unknown = IntermediateSecurityDistributionTypeV2Code.Unknown, // same ordinal as derivation source for type conversions
}
