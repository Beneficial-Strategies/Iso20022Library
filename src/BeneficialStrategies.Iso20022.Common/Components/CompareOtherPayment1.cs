// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies two values to compare related to payment data attributes not reported in dedicated fields.
/// </summary>
[IsoId("_5w6zAYpbEeyVdPSarESe_A")]
[DisplayName("Compare Other Payment")]
public record CompareOtherPayment1
{
    /// <summary>
    /// Specifies whether the information on the other payment types are matching or not.
    /// </summary>
    [IsoId("_LD9oIIpcEeyVdPSarESe_A")]
    [DisplayName("Other Payment Type")]
    [IsoXmlTag("OthrPmtTp")]
    public CompareOtherPaymentType1? OtherPaymentType { get; init; }

    /// <summary>
    /// Specifies whether the information on the other payment amounts are matching or not.
    /// </summary>
    [IsoId("_O1IMoIpcEeyVdPSarESe_A")]
    [DisplayName("Other Payment Amount")]
    [IsoXmlTag("OthrPmtAmt")]
    public CompareAmountAndDirection3? OtherPaymentAmount { get; init; }

    /// <summary>
    /// Specifies whether the information on the other payment dates are matching or not.
    /// </summary>
    [IsoId("_SP2AAIpcEeyVdPSarESe_A")]
    [DisplayName("Other Payment Date")]
    [IsoXmlTag("OthrPmtDt")]
    public CompareDate3? OtherPaymentDate { get; init; }

    /// <summary>
    /// Specifies whether the information on the other payment payers are matching or not.
    /// </summary>
    [IsoId("_WcZgAIpcEeyVdPSarESe_A")]
    [DisplayName("Other Payment Payer")]
    [IsoXmlTag("OthrPmtPyer")]
    public CompareOrganisationIdentification7? OtherPaymentPayer { get; init; }

    /// <summary>
    /// Specifies whether the information on the other payment receivers are matching or not.
    /// </summary>
    [IsoId("_Z0F0kIpcEeyVdPSarESe_A")]
    [DisplayName("Other Payment Receiver")]
    [IsoXmlTag("OthrPmtRcvr")]
    public CompareOrganisationIdentification7? OtherPaymentReceiver { get; init; }
}
