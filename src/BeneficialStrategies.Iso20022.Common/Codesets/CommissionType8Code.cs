// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Used to identify soft trades at order entry.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_bAHcgdp-Ed-ak6NoX_4Aeg_365784850")]
[Description(@"Used to identify soft trades at order entry.")]
[DerivedFrom(typeof(CommissionTypeV2Code))]
public enum CommissionType8Code
{
    /// <summary>
    /// Commission for a step-out trade, charged by the step-out broker.
    /// Encoded/decoded by serializers as &quot;STEP&quot;.
    /// </summary>
    [EnumMember(Value = "STEP")]
    [IsoId("_bAHcgtp-Ed-ak6NoX_4Aeg_411961030")]
    [Description(@"Commission for a step-out trade, charged by the step-out broker.")]
    StepOut = CommissionTypeV2Code.StepOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission that is regular.
    /// Encoded/decoded by serializers as &quot;REGU&quot;.
    /// </summary>
    [EnumMember(Value = "REGU")]
    [IsoId("_bAHcg9p-Ed-ak6NoX_4Aeg_665931315")]
    [Description(@"Commission that is regular.")]
    Regular = CommissionTypeV2Code.Regular, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission for a step-in trade, charged by the step-in broker.
    /// Encoded/decoded by serializers as &quot;STEI&quot;.
    /// </summary>
    [EnumMember(Value = "STEI")]
    [IsoId("_bAHchNp-Ed-ak6NoX_4Aeg_665931567")]
    [Description(@"Commission for a step-in trade, charged by the step-in broker.")]
    StepIn = CommissionTypeV2Code.StepIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission designated by the broker for third party services. The soft dollar arrangement refers to an arrangement wherean investment manager directs transactions to a brokerand, in exchange, the broker provides brokerage and research services to the investment manager. Soft dollar arrangements include proprietary and third party research arrangements, but do not include client-directed brokerage arrangements. The U.S. Securities Exchange Act of 1934, Section 238(e), created a &quot;safe harbor&quot; to protect investment managers from claims that they had breached their fiduciary duties by using their client commissions to pay a higher commission than they might have paid for execution services to acquire investment research. The SEC defines soft dollars as: The Commission has defined soft dollar practices as arrangements under which products or services, other than execution of securities transactions, are obtained through an adviser or a broker-dealer in exchange for the direction by the adviser of client brokerage transactions to the broker-dealer. An individual or firm must exercise &quot;investment discretion&quot; over an account, as defined in Section 3(a)(35) of the Exchange Act, in order to use client commissions to obtain research under Section 28(e) of the Exchange Act (&quot;Section 28(e)&quot;).
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("_bAHchdp-Ed-ak6NoX_4Aeg_665931602")]
    [Description(
        @"Commission designated by the broker for third party services. The soft dollar arrangement refers to an arrangement wherean investment manager directs transactions to a brokerand, in exchange, the broker provides brokerage and research services to the investment manager. Soft dollar arrangements include proprietary and third party research arrangements, but do not include client-directed brokerage arrangements. The U.S. Securities Exchange Act of 1934, Section 238(e), created a ""safe harbor"" to protect investment managers from claims that they had breached their fiduciary duties by using their client commissions to pay a higher commission than they might have paid for execution services to acquire investment research. The SEC defines soft dollars as: The Commission has defined soft dollar practices as arrangements under which products or services, other than execution of securities transactions, are obtained through an adviser or a broker-dealer in exchange for the direction by the adviser of client brokerage transactions to the broker-dealer. An individual or firm must exercise ""investment discretion"" over an account, as defined in Section 3(a)(35) of the Exchange Act, in order to use client commissions to obtain research under Section 28(e) of the Exchange Act (""Section 28(e)"")."
    )]
    SoftDollar = CommissionTypeV2Code.SoftDollar, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission that combines soft dollar and step-in commission characteristics.
    /// Encoded/decoded by serializers as &quot;SOIN&quot;.
    /// </summary>
    [EnumMember(Value = "SOIN")]
    [IsoId("_bAHchtp-Ed-ak6NoX_4Aeg_665931644")]
    [Description(@"Commission that combines soft dollar and step-in commission characteristics.")]
    SoftDollarStepIn = CommissionTypeV2Code.SoftDollarStepIn, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission that combines soft dollar and step-out commission characteristics.
    /// Encoded/decoded by serializers as &quot;SOUT&quot;.
    /// </summary>
    [EnumMember(Value = "SOUT")]
    [IsoId("_bAHch9p-Ed-ak6NoX_4Aeg_666851676")]
    [Description(@"Commission that combines soft dollar and step-out commission characteristics.")]
    SoftDollarStepOut = CommissionTypeV2Code.SoftDollarStepOut, // same ordinal as derivation source for type conversions

    /// <summary>
    /// Commission for a plan sponsor&apos;s services.
    /// Encoded/decoded by serializers as &quot;PLAN&quot;.
    /// </summary>
    [EnumMember(Value = "PLAN")]
    [IsoId("_bAHciNp-Ed-ak6NoX_4Aeg_707489684")]
    [Description(@"Commission for a plan sponsor's services.")]
    PlanSponsor = CommissionTypeV2Code.PlanSponsor, // same ordinal as derivation source for type conversions
}
