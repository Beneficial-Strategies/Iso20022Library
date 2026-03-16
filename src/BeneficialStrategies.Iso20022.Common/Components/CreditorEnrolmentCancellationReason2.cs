// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the creditor enrolment cancellation request.
/// </summary>
[IsoId("_Ufpx-eH7Eeqbls7Gk4-ckA")]
[DisplayName("Creditor Enrolment Cancellation Reason")]
public record CreditorEnrolmentCancellationReason2
{
    /// <summary>
    /// Party that issues the cancellation request.
    /// </summary>
    [IsoId("_Ug_1weH7Eeqbls7Gk4-ckA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public RTPPartyIdentification1? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the cancellation request.
    /// </summary>
    [IsoId("_Ug_1w-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CreditorEnrolmentCancellationReason1Choice_ Reason { get; init; }

    /// <summary>
    /// Further details on the cancellation request reason.
    /// </summary>
    [IsoId("_Ug_1xeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
