// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_1rD7UzL3EeKU9IrkkToqcw_1294109799")]
[Description(
    @"Specifies DTCC (The Depository Trust and Clearing Corporation) defined payout types."
)]
[DerivedFrom(typeof(DTCCPayoutTypeCode))]
public enum DTCCPayoutType1Code
{
    /// <summary>
    /// Payout consisting of cash.
    /// Encoded/decoded by serializers as &quot;CASH&quot;.
    /// </summary>
    [EnumMember(Value = "CASH")]
    [IsoId("_1rD7VDL3EeKU9IrkkToqcw_-862845894")]
    [Description(@"Payout consisting of cash.")]
    Cash = DTCCPayoutTypeCode.Cash, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of earnings to shareholders categorised by company as dividend.
    /// Encoded/decoded by serializers as &quot;DIVI&quot;.
    /// </summary>
    [EnumMember(Value = "DIVI")]
    [IsoId("_1rD7VTL3EeKU9IrkkToqcw_437551662")]
    [Description(@"Distribution of earnings to shareholders categorised by company as dividend.")]
    Dividend = DTCCPayoutTypeCode.Dividend, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution that doesn&apos;t represent earnings and is categorised by the company as return of capital.
    /// Encoded/decoded by serializers as &quot;ROCA&quot;.
    /// </summary>
    [EnumMember(Value = "ROCA")]
    [IsoId("_1rD7VjL3EeKU9IrkkToqcw_-83641118")]
    [Description(
        @"Distribution that doesn't represent earnings and is categorised by the company as return of capital."
    )]
    ReturnOfCapital = DTCCPayoutTypeCode.ReturnOfCapital, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as short-term capital gains.
    /// Encoded/decoded by serializers as &quot;STCG&quot;.
    /// </summary>
    [EnumMember(Value = "STCG")]
    [IsoId("_1rNsUDL3EeKU9IrkkToqcw_1591425023")]
    [Description(
        @"Distribution of earnings to shareholders categorised by the company as short-term capital gains."
    )]
    ShortTermCapitalGains = DTCCPayoutTypeCode.ShortTermCapitalGains, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as long-term capital gains.
    /// Encoded/decoded by serializers as &quot;LTCG&quot;.
    /// </summary>
    [EnumMember(Value = "LTCG")]
    [IsoId("_1rNsUTL3EeKU9IrkkToqcw_1477585957")]
    [Description(
        @"Distribution of earnings to shareholders categorised by the company as long-term capital gains."
    )]
    LongTermCapitalGains = DTCCPayoutTypeCode.LongTermCapitalGains, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Distribution of earnings to shareholders categorised by the company as capital gains.
    /// Encoded/decoded by serializers as &quot;CAPG&quot;.
    /// </summary>
    [EnumMember(Value = "CAPG")]
    [IsoId("_1rNsUjL3EeKU9IrkkToqcw_-252443966")]
    [Description(
        @"Distribution of earnings to shareholders categorised by the company as capital gains."
    )]
    CapitalGains = DTCCPayoutTypeCode.CapitalGains, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash payment that is categorised by the issuer as premium, usually offered as incentive for early participation in an offer.
    /// Encoded/decoded by serializers as &quot;PREM&quot;.
    /// </summary>
    [EnumMember(Value = "PREM")]
    [IsoId("_1rNsUzL3EeKU9IrkkToqcw_-366283032")]
    [Description(
        @"Cash payment that is categorised by the issuer as premium, usually offered as incentive for early participation in an offer."
    )]
    Premium = DTCCPayoutTypeCode.Premium, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash payment on a debt instrument that represents a return of principal to the holder.
    /// Encoded/decoded by serializers as &quot;PRPL&quot;.
    /// </summary>
    [EnumMember(Value = "PRPL")]
    [IsoId("_1rNsVDL3EeKU9IrkkToqcw_1736509643")]
    [Description(
        @"Cash payment on a debt instrument that represents a return of principal to the holder."
    )]
    Principal = DTCCPayoutTypeCode.Principal, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Cash payment on a debt instrument calculated using the coupon rate, principal and period of time.
    /// Encoded/decoded by serializers as &quot;INTR&quot;.
    /// </summary>
    [EnumMember(Value = "INTR")]
    [IsoId("_1rNsVTL3EeKU9IrkkToqcw_-1797692500")]
    [Description(
        @"Cash payment on a debt instrument calculated using the coupon rate, principal and period of time."
    )]
    Interest = DTCCPayoutTypeCode.Interest, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In some markets, companies further categorize dividends as franked or unfranked. &quot;Franked&quot; means that a tax credit is attached to that part of the dividend.
    /// Encoded/decoded by serializers as &quot;FLFR&quot;.
    /// </summary>
    [EnumMember(Value = "FLFR")]
    [IsoId("_1rNsVjL3EeKU9IrkkToqcw_-1911531566")]
    [Description(
        @"In some markets, companies further categorize dividends as franked or unfranked. ""Franked"" means that a tax credit is attached to that part of the dividend."
    )]
    Franked = DTCCPayoutTypeCode.Franked, // same ordinal as derivation source for type conversions

    /// <summary>
    /// In some markets, companies further categorize dividends as franked or unfranked. &quot;Unfranked&quot; means that there is no tax credit attached to the dividend.
    /// Encoded/decoded by serializers as &quot;UNFR&quot;.
    /// </summary>
    [EnumMember(Value = "UNFR")]
    [IsoId("_1rW2QDL3EeKU9IrkkToqcw_33230669")]
    [Description(
        @"In some markets, companies further categorize dividends as franked or unfranked. ""Unfranked"" means that there is no tax credit attached to the dividend."
    )]
    Unfranked = DTCCPayoutTypeCode.Unfranked, // same ordinal as derivation source for type conversions
}
