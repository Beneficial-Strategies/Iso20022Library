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
[IsoId("_SGUqQ249EeiU9cctagi5ow")]
[DisplayName("Mandate Amendment Reason")]
public record MandateAmendmentReason2
{
    /// <summary>
    /// Party that issues the amendment request.
    /// </summary>
    [IsoId("_SPtPk249EeiU9cctagi5ow")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification135? Originator { get; init; }

    /// <summary>
    /// Specifies the reason for the amendment request.
    /// </summary>
    [IsoId("_SPtPlW49EeiU9cctagi5ow")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public required MandateReason1Choice_ Reason { get; init; }

    /// <summary>
    /// Further details on the amendment request reason.
    /// </summary>
    [IsoId("_SPtPl249EeiU9cctagi5ow")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105, MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; }
}
