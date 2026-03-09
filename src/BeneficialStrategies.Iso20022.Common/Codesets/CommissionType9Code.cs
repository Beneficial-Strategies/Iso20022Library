// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Type of service for which the commission is asked or paid.
/// </summary>
[DataContract]
[Serializable]
[IsoId("__1f1pNojEeC60axPepSq7g_1349927182")]
[Description(@"Type of service for which the commission is asked or paid.")]
[DerivedFrom(typeof(CommissionTypeV2Code))]
public enum CommissionType9Code
{
    /// <summary>
    /// Commission is as per client agreement.
    /// Encoded/decoded by serializers as &quot;CLDI&quot;.
    /// </summary>
    [EnumMember(Value = "CLDI")]
    [IsoId("__1f1pdojEeC60axPepSq7g_1512056713")]
    [Description(@"Commission is as per client agreement.")]
    ClientDirected = CommissionTypeV2Code.ClientDirected, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commission for a step-out trade, charged by the step-out broker.
    /// Encoded/decoded by serializers as &quot;STEP&quot;.
    /// </summary>
    [EnumMember(Value = "STEP")]
    [IsoId("__1f1ptojEeC60axPepSq7g_-1258842287")]
    [Description(@"Commission for a step-out trade, charged by the step-out broker.")]
    StepOut = CommissionTypeV2Code.StepOut, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commission designated by the broker for third party services. The soft dollar arrangement refers to an arrangement wherean investment manager directs transactions to a brokerand, in exchange, the broker provides brokerage and research services to the investment manager. Soft dollar arrangements include proprietary and third party research arrangements, but do not include client-directed brokerage arrangements. The U.S. Securities Exchange Act of 1934, Section 238(e), created a &quot;safe harbor&quot; to protect investment managers from claims that they had breached their fiduciary duties by using their client commissions to pay a higher commission than they might have paid for execution services to acquire investment research. The SEC defines soft dollars as: The Commission has defined soft dollar practices as arrangements under which products or services, other than execution of securities transactions, are obtained through an adviser or a broker-dealer in exchange for the direction by the adviser of client brokerage transactions to the broker-dealer. An individual or firm must exercise &quot;investment discretion&quot; over an account, as defined in Section 3(a)(35) of the Exchange Act, in order to use client commissions to obtain research under Section 28(e) of the Exchange Act (&quot;Section 28(e)&quot;).
    /// Encoded/decoded by serializers as &quot;SOFT&quot;.
    /// </summary>
    [EnumMember(Value = "SOFT")]
    [IsoId("__1pmoNojEeC60axPepSq7g_1775834527")]
    [Description(@"Commission designated by the broker for third party services. The soft dollar arrangement refers to an arrangement wherean investment manager directs transactions to a brokerand, in exchange, the broker provides brokerage and research services to the investment manager. Soft dollar arrangements include proprietary and third party research arrangements, but do not include client-directed brokerage arrangements. The U.S. Securities Exchange Act of 1934, Section 238(e), created a ""safe harbor"" to protect investment managers from claims that they had breached their fiduciary duties by using their client commissions to pay a higher commission than they might have paid for execution services to acquire investment research. The SEC defines soft dollars as: The Commission has defined soft dollar practices as arrangements under which products or services, other than execution of securities transactions, are obtained through an adviser or a broker-dealer in exchange for the direction by the adviser of client brokerage transactions to the broker-dealer. An individual or firm must exercise ""investment discretion"" over an account, as defined in Section 3(a)(35) of the Exchange Act, in order to use client commissions to obtain research under Section 28(e) of the Exchange Act (""Section 28(e)"").")]
    SoftDollar = CommissionTypeV2Code.SoftDollar, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commission is a percentage of principal.
    /// Encoded/decoded by serializers as &quot;PERN&quot;.
    /// </summary>
    [EnumMember(Value = "PERN")]
    [IsoId("__1pmodojEeC60axPepSq7g_873266936")]
    [Description(@"Commission is a percentage of principal.")]
    PercentageOfPrincipal = CommissionTypeV2Code.PercentageOfPrincipal, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commission is a flat fee.
    /// Encoded/decoded by serializers as &quot;FLAT&quot;.
    /// </summary>
    [EnumMember(Value = "FLAT")]
    [IsoId("__1pmotojEeC60axPepSq7g_1287212868")]
    [Description(@"Commission is a flat fee.")]
    FlatFee = CommissionTypeV2Code.FlatFee, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commission is per unit of financial instrument.
    /// Encoded/decoded by serializers as &quot;PERU&quot;.
    /// </summary>
    [EnumMember(Value = "PERU")]
    [IsoId("__1pmo9ojEeC60axPepSq7g_1438210713")]
    [Description(@"Commission is per unit of financial instrument.")]
    PerUnit = CommissionTypeV2Code.PerUnit, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commission is a percentage commission waived as cash discount.
    /// Encoded/decoded by serializers as &quot;PWCD&quot;.
    /// </summary>
    [EnumMember(Value = "PWCD")]
    [IsoId("__1pmpNojEeC60axPepSq7g_-1332688287")]
    [Description(@"Commission is a percentage commission waived as cash discount.")]
    PercentageCommissionWaivedAsCashDiscount = CommissionTypeV2Code.PercentageCommissionWaivedAsCashDiscount, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commission is a percentage commission waived as additional units.
    /// Encoded/decoded by serializers as &quot;PWEU&quot;.
    /// </summary>
    [EnumMember(Value = "PWEU")]
    [IsoId("__1pmpdojEeC60axPepSq7g_366205654")]
    [Description(@"Commission is a percentage commission waived as additional units.")]
    PercentageCommissionWaivedAsAdditionalUnits = CommissionTypeV2Code.PercentageCommissionWaivedAsAdditionalUnits, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Brokerage commission.
    /// Encoded/decoded by serializers as &quot;BRKR&quot;.
    /// </summary>
    [EnumMember(Value = "BRKR")]
    [IsoId("__1pmptojEeC60axPepSq7g_970428610")]
    [Description(@"Brokerage commission.")]
    BrokerageRate = CommissionTypeV2Code.BrokerageRate, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Differential or deferred payment commission rate.  .
    /// Encoded/decoded by serializers as &quot;DFDP&quot;.
    /// </summary>
    [EnumMember(Value = "DFDP")]
    [IsoId("__1ywkNojEeC60axPepSq7g_1148547282")]
    [Description(@"Differential or deferred payment commission rate.  .")]
    DifferentialOrDeferredPayment = CommissionTypeV2Code.DifferentialOrDeferredPayment, // same ordinal as derivation source for type conversions
    
    /// <summary>
    /// Commission is based on points per bond or contract.
    /// Encoded/decoded by serializers as &quot;PBOC&quot;.
    /// </summary>
    [EnumMember(Value = "PBOC")]
    [IsoId("__1ywkdojEeC60axPepSq7g_278267935")]
    [Description(@"Commission is based on points per bond or contract.")]
    PointsPerBondOrContract = CommissionTypeV2Code.PointsPerBondOrContract, // same ordinal as derivation source for type conversions
    
}
