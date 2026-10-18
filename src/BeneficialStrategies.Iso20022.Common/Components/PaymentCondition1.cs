// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IPaymentCondition1"/>
[IsoId("_BmRRkHVjEeiEU7thYTAN1w")]
[DisplayName("Payment Condition")]
public partial record PaymentCondition1
{
    /// <inheritdoc cref="IPaymentCondition1.AmountModificationAllowed"/>
    [IsoId("_zg-VYHVjEeiEU7thYTAN1w")]
    [DisplayName("Amount Modification Allowed")]
    [IsoXmlTag("AmtModAllwd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator AmountModificationAllowed { get; init; }

    /// <inheritdoc cref="IPaymentCondition1.EarlyPaymentAllowed"/>
    [IsoId("_3QRRoXVjEeiEU7thYTAN1w")]
    [DisplayName("Early Payment Allowed")]
    [IsoXmlTag("EarlyPmtAllwd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator EarlyPaymentAllowed { get; init; }

    /// <inheritdoc cref="IPaymentCondition1.DelayPenalty"/>
    [IsoId("_YiSE4HVkEeiEU7thYTAN1w")]
    [DisplayName("Delay Penalty")]
    [IsoXmlTag("DelyPnlty")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140, MinimumLength = 1)]
    public IsoMax140Text? DelayPenalty { get; init; }

    /// <inheritdoc cref="IPaymentCondition1.ImmediatePaymentRebate"/>
    [IsoId("_jw1A8HVkEeiEU7thYTAN1w")]
    [DisplayName("Immediate Payment Rebate")]
    [IsoXmlTag("ImdtPmtRbt")]
    public AmountOrRate1Choice_? ImmediatePaymentRebate { get; init; }

    /// <inheritdoc cref="IPaymentCondition1.GuaranteedPaymentRequested"/>
    [IsoId("_-63wYHVkEeiEU7thYTAN1w")]
    [DisplayName("Guaranteed Payment Requested")]
    [IsoXmlTag("GrntedPmtReqd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public required IsoTrueFalseIndicator GuaranteedPaymentRequested { get; init; }
}
