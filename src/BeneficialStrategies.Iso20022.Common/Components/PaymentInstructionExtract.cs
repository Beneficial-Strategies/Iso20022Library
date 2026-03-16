// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Details of a payment instruction. The information contained in this component is sufficient to retrieve a payment instruction.
/// </summary>
[IsoId("_VQgOUtp-Ed-ak6NoX_4Aeg_-769020295")]
[DisplayName("Payment Instruction Extract")]
public record PaymentInstructionExtract
{
    /// <summary>
    /// Identification of the payment instruction (eg, field 20 of an MT 103) when meaningful to the case assigner.
    /// </summary>
    [IsoId("_VQgOU9p-Ed-ak6NoX_4Aeg_56776664")]
    [DisplayName("Assigner Instruction Identification")]
    [IsoXmlTag("AssgnrInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssignerInstructionIdentification { get; init; }

    /// <summary>
    /// Identification of the payment instruction (eg, field 20 of an MT 103) when meaningful to the case assignee.
    /// </summary>
    [IsoId("_VQgOVNp-Ed-ak6NoX_4Aeg_585203601")]
    [DisplayName("Assignee Instruction Identification")]
    [IsoXmlTag("AssgneInstrId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssigneeInstructionIdentification { get; init; }

    /// <summary>
    /// Amount of the payment. Depending on the context it can be either the amount settled (UnableToApply) or the instructed amount (RequestToCancel, RequestToModify, ClaimNonReceipt).
    /// </summary>
    [IsoId("_VQgOVdp-Ed-ak6NoX_4Aeg_-745398050")]
    [DisplayName("Currency Amount")]
    [IsoXmlTag("CcyAmt")]
    public CurrencyAndAmount? CurrencyAmount { get; init; }

    /// <summary>
    /// Value date of the payment.
    /// </summary>
    [IsoId("_VQgOVtp-Ed-ak6NoX_4Aeg_-659512363")]
    [DisplayName("Value Date")]
    [IsoXmlTag("ValDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    public IsoISODateTime? ValueDate { get; init; }
}
