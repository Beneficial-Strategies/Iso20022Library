// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the suspension reason.
/// </summary>
[IsoId("_8kzj0H5pEea7cqFPsAF3tQ")]
[DisplayName("Mandate Suspension Reason")]
public record MandateSuspensionReason1
{
    /// <summary>
    /// Party that issues the suspension request.
    /// </summary>
    [IsoId("_M7al4H5qEea7cqFPsAF3tQ")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification43? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the suspension request.
    /// </summary>
    [IsoId("_RLq6IH5qEea7cqFPsAF3tQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateSuspensionReason1Choice_ Reason { get; init; }

    /// <summary>
    /// Further details on the suspension request reason.
    /// </summary>
    [IsoId("_W8oMIH5qEea7cqFPsAF3tQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
