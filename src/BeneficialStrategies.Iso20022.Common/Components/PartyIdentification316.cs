// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification316.
/// </summary>
[IsoId("_xX3b44-_Ee-COKgew96POA")]
[DisplayName("Party Identification316")]
public record PartyIdentification316
{
    /// <summary>
    /// Alternate Identification.
    /// </summary>
    [DisplayName("Alternate Identification")]
    [IsoXmlTag("AltrnId")]
    public ValueList<AlternatePartyIdentification7> AlternateIdentification { get; init; } = [];

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification257Choice_ Identification { get; init; }

    /// <summary>
    /// Processing Identification.
    /// </summary>
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    public IsoMax35Text? ProcessingIdentification { get; init; }
}
