// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="IMandateSuspensionReason1"/>
[IsoId("_8kzj0H5pEea7cqFPsAF3tQ")]
[DisplayName("Mandate Suspension Reason")]
public partial record MandateSuspensionReason1
{
    /// <inheritdoc cref="IMandateSuspensionReason1.Originator"/>
    [IsoId("_M7al4H5qEea7cqFPsAF3tQ")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification43? Originator { get; init; }

    /// <inheritdoc cref="IMandateSuspensionReason1.Reason"/>
    [IsoId("_RLq6IH5qEea7cqFPsAF3tQ")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateSuspensionReason1Choice_ Reason { get; init; }

    /// <inheritdoc cref="IMandateSuspensionReason1.AdditionalInformation"/>
    [IsoId("_W8oMIH5qEea7cqFPsAF3tQ")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public SimpleValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];
}
