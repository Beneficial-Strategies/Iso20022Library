// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <inheritdoc cref="ISupplementaryData1"/>
[IsoId("_Qn0zC9p-Ed-ak6NoX_4Aeg_468227563")]
[DisplayName("Supplementary Data")]
public partial record SupplementaryData1
{
    /// <inheritdoc cref="ISupplementaryData1.PlaceAndName"/>
    [IsoId("_Qn988Np-Ed-ak6NoX_4Aeg_354388497")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? PlaceAndName { get; init; }

    /// <inheritdoc cref="ISupplementaryData1.Envelope"/>
    [IsoId("_Qn988dp-Ed-ak6NoX_4Aeg_-642683856")]
    [DisplayName("Envelope")]
    [IsoXmlTag("Envlp")]
    public required SupplementaryDataEnvelope1 Envelope { get; init; }
}
