// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1o-QojL3EeKU9IrkkToqcw_-806320900")]
[Description(
    @"Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types."
)]
[Derivations(
    typeof(DTCCPayoutType4Code),
    typeof(DTCCPayoutType3Code),
    typeof(DTCCPayoutType5Code),
    typeof(DTCCPayoutType1Code),
    typeof(DTCCPayoutType2Code)
)]
public enum DTCCPayoutTypeCode
{
    /// <summary>
    /// Payout consisting of cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_1o-QozL3EeKU9IrkkToqcw_-834385062")]
    [Description(@"Payout consisting of cash.")]
    Cash,

    /// <summary>
    /// Payout consisting of securities.
    /// Encoded/decoded by serializers as &quot;SECU&quot;.
    /// </summary>
    [EnumMember(Value = "SECU")]
    [IsoId("_1o-QpDL3EeKU9IrkkToqcw_702376988")]
    [Description(@"Payout consisting of securities.")]
    Securities,

    /// <summary>
    /// Distribution of earnings to shareholders categorised by company as dividend.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_1o-QpTL3EeKU9IrkkToqcw_-1870772597")]
    [Description(@"Distribution of earnings to shareholders categorised by company as dividend.")]
    Dividend,

    /// <summary>
    /// Distribution that doesn&apos;t represent earnings and is categorised by the company as return of capital.
    /// Encoded/decoded by serializers as &quot;ROCA&quot;.
    /// </summary>
    [EnumMember(Value = "ROCA")]
    [IsoId("_1o-QpjL3EeKU9IrkkToqcw_-359228468")]
    [Description(
        @"Distribution that doesn't represent earnings and is categorised by the company as return of capital."
    )]
    ReturnOfCapital,

    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as short-term capital gains.
    /// Encoded/decoded by serializers as &quot;STCG&quot;.
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_1pIBoDL3EeKU9IrkkToqcw_1506061219")]
    [Description(
        @"Distribution of earnings to shareholders categorised by the company as short-term capital gains."
    )]
    ShortTermCapitalGains,

    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as long-term capital gains.
    /// Encoded/decoded by serializers as &quot;LTCG&quot;.
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_1pIBoTL3EeKU9IrkkToqcw_2040405331")]
    [Description(
        @"Distribution of earnings to shareholders categorised by the company as long-term capital gains."
    )]
    LongTermCapitalGains,

    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as capital gains.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_1pIBojL3EeKU9IrkkToqcw_-1084357800")]
    [Description(
        @"Distribution of earnings to shareholders categorised by the company as capital gains."
    )]
    CapitalGains,

    /// <summary>
    /// Cash payment that is categorised by the issuer as premium, usually offered as incentive for early participation in an offer.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_1pIBozL3EeKU9IrkkToqcw_-1747991352")]
    [Description(
        @"Cash payment that is categorised by the issuer as premium, usually offered as incentive for early participation in an offer."
    )]
    Premium,

    /// <summary>
    /// Cash payment on a debt instrument that represents a return of principal to the holder.
    /// Encoded/decoded by serializers as &quot;PRPL&quot;.
    /// </summary>
    [EnumMember(Value = "PRPL")]
    [IsoId("_1pIBpDL3EeKU9IrkkToqcw_-343213628")]
    [Description(
        @"Cash payment on a debt instrument that represents a return of principal to the holder."
    )]
    Principal,

    /// <summary>
    /// Cash payment on a debt instrument calculated using the coupon rate, principal and period of time.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_1pIBpTL3EeKU9IrkkToqcw_1108680864")]
    [Description(
        @"Cash payment on a debt instrument calculated using the coupon rate, principal and period of time."
    )]
    Interest,

    /// <summary>
    /// In some markets, companies further categorize dividends as franked or unfranked. &quot;Franked&quot; means that a tax credit is attached to that part of the dividend.
    /// Encoded/decoded by serializers as &quot;FLFR&quot;.
    /// </summary>
    [EnumMember(Value = "FLFR")]
    [IsoId("_1pIBpjL3EeKU9IrkkToqcw_-779183644")]
    [Description(
        @"In some markets, companies further categorize dividends as franked or unfranked. ""Franked"" means that a tax credit is attached to that part of the dividend."
    )]
    Franked,

    /// <summary>
    /// In some markets, companies further categorize dividends as franked or unfranked. &quot;Unfranked&quot; means that there is no tax credit attached to the dividend.
    /// Encoded/decoded by serializers as &quot;UNFR&quot;.
    /// </summary>
    [EnumMember(Value = "UNFR")]
    [IsoId("_1pRyoDL3EeKU9IrkkToqcw_-1942490306")]
    [Description(
        @"In some markets, companies further categorize dividends as franked or unfranked. ""Unfranked"" means that there is no tax credit attached to the dividend."
    )]
    Unfranked,

    /// <summary>
    /// Applies when a specific payout code cannot be used.
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_1pRyoTL3EeKU9IrkkToqcw_86152619")]
    [Description(@"Applies when a specific payout code cannot be used.")]
    Other,

    /// <summary>
    /// Payout consisting of a tax credit.
    /// Encoded/decoded by serializers as &quot;TXCR&quot;.
    /// </summary>
    [EnumMember(Value = "TXCR")]
    [IsoId("_iGgLQJCMEeaSk9d1hvTrHg")]
    [Description(@"Payout consisting of a tax credit.")]
    TaxCredit,
}
