// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification318.
/// </summary>
[IsoId("_kv8aNZt3Ee-wQIOX0djF2w")]
[DisplayName("Party Identification318")]
public record PartyIdentification318
{
    /// <summary>
    /// Alternate Identification.
    /// </summary>
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public ValueList<AlternatePartyIdentification9> AlternateIdentification { get; init; } = [];

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification258Choice_ Identification { get; init; }

    /// <summary>
    /// Processing Identification.
    /// </summary>
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    public IsoRestrictedFINXMax16Text? ProcessingIdentification { get; init; }
}
