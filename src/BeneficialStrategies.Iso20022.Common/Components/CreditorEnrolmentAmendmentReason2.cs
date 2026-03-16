// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the amendment of the creditor enrolment.
/// </summary>
[IsoId("_UiRoIeH7Eeqbls7Gk4-ckA")]
[DisplayName("Creditor Enrolment Amendment Reason")]
public record CreditorEnrolmentAmendmentReason2
{
    /// <summary>
    /// Party that issues the amendment request.
    /// </summary>
    [IsoId("_UjZCceH7Eeqbls7Gk4-ckA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public RTPPartyIdentification1? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the amendment request.
    /// </summary>
    [IsoId("_UjZCc-H7Eeqbls7Gk4-ckA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required CreditorEnrolmentAmendmentReason1Choice_ Reason { get; init; }

    /// <summary>
    /// Further details on the amendment request reason.
    /// </summary>
    [IsoId("_UjZCdeH7Eeqbls7Gk4-ckA")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
