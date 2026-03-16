// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Reflection;
using System.Runtime.Serialization;

namespace BeneficialStrategies.Iso20022.Codesets;

/// <summary>
/// Specifies the reason why a reversal of payment is taking place in corporate action processing.
/// </summary>
[DataContract]
[Serializable]
[IsoId("_CorporateActionReversalReason3Code")]
[Description(@"Specifies the reason why a reversal of payment is taking place in corporate action processing.")]
[DerivedFrom(typeof(CorporateActionReversalReasonV2Code))]
public enum CorporateActionReversalReason3Code
{
    /// <summary>
    /// Difference in day count basis.
    /// Encoded/decoded by serializers as &quot;DCBD&quot;.
    /// </summary>
    [EnumMember(Value = "DCBD")]
    [IsoId("_CorporateActionReversalReason3Code_DayCountBasisDifference")]
    [Description(@"Difference in day count basis.")]
    DayCountBasisDifference = CorporateActionReversalReasonV2Code.DayCountBasisDifference,

    /// <summary>
    /// Funds have not been received.
    /// Encoded/decoded by serializers as &quot;FNRC&quot;.
    /// </summary>
    [EnumMember(Value = "FNRC")]
    [IsoId("_CorporateActionReversalReason3Code_FundsNotReceived")]
    [Description(@"Funds have not been received.")]
    FundsNotReceived = CorporateActionReversalReasonV2Code.FundsNotReceived,

    /// <summary>
    /// Event level tax rate is incorrect.
    /// Encoded/decoded by serializers as &quot;IETR&quot;.
    /// </summary>
    [EnumMember(Value = "IETR")]
    [IsoId("_CorporateActionReversalReason3Code_IncorrectEventLevelTaxRate")]
    [Description(@"Event level tax rate is incorrect.")]
    IncorrectEventLevelTaxRate = CorporateActionReversalReasonV2Code.IncorrectEventLevelTaxRate,

    /// <summary>
    /// Payment currency is incorrect.
    /// Encoded/decoded by serializers as &quot;IPCU&quot;.
    /// </summary>
    [EnumMember(Value = "IPCU")]
    [IsoId("_CorporateActionReversalReason3Code_IncorrectPaymentCurrency")]
    [Description(@"Payment currency is incorrect.")]
    IncorrectPaymentCurrency = CorporateActionReversalReasonV2Code.IncorrectPaymentCurrency,

    /// <summary>
    /// Price is incorrect.
    /// Encoded/decoded by serializers as &quot;IPRI&quot;.
    /// </summary>
    [EnumMember(Value = "IPRI")]
    [IsoId("_CorporateActionReversalReason3Code_IncorrectPrice")]
    [Description(@"Price is incorrect.")]
    IncorrectPrice = CorporateActionReversalReasonV2Code.IncorrectPrice,

    /// <summary>
    /// Entitlement date is incorrect.
    /// Encoded/decoded by serializers as &quot;IRED&quot;.
    /// </summary>
    [EnumMember(Value = "IRED")]
    [IsoId("_CorporateActionReversalReason3Code_IncorrectEntitlementDate")]
    [Description(@"Entitlement date is incorrect.")]
    IncorrectEntitlementDate = CorporateActionReversalReasonV2Code.IncorrectEntitlementDate,

    /// <summary>
    /// Value date is incorrect.
    /// Encoded/decoded by serializers as &quot;IVAD&quot;.
    /// </summary>
    [EnumMember(Value = "IVAD")]
    [IsoId("_CorporateActionReversalReason3Code_IncorrectValueDate")]
    [Description(@"Value date is incorrect.")]
    IncorrectValueDate = CorporateActionReversalReasonV2Code.IncorrectValueDate,

    /// <summary>
    /// Other
    /// Encoded/decoded by serializers as &quot;OTHR&quot;.
    /// </summary>
    [EnumMember(Value = "OTHR")]
    [IsoId("_CorporateActionReversalReason3Code_Other")]
    [Description(@"Other")]
    Other,

    /// <summary>
    /// Payment is not due.
    /// Encoded/decoded by serializers as &quot;UPAY&quot;.
    /// </summary>
    [EnumMember(Value = "UPAY")]
    [IsoId("_CorporateActionReversalReason3Code_UnduePayment")]
    [Description(@"Payment is not due.")]
    UnduePayment = CorporateActionReversalReasonV2Code.UnduePayment,

}
