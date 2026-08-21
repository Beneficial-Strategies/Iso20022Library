// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides further details on the reason of the amendment of the mandate.
/// </summary>
[IsoId("_yUI4ITEyEe6g-ffJsqGiSA")]
[DisplayName("Mandate Amendment Reason3")]
public record MandateAmendmentReason3
{
    /// <summary>
    /// Further details on the amendment request reason.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Party that issues the amendment request.
    /// </summary>
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification272? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the amendment request.
    /// </summary>
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateReason1Choice_ Reason { get; init; }
}
