// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Identification314.
/// </summary>
[IsoId("_Nwuw4YopEe-efPejSUAtLw")]
[DisplayName("Party Identification314")]
public record PartyIdentification314
{
    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification257Choice_ Identification { get; init; }

    /// <summary>
    /// LEI.
    /// </summary>
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    public IsoLEIIdentifier? LEI { get; init; }

    /// <summary>
    /// Processing Identification.
    /// </summary>
    [DisplayName("Processing Identification")]
    [IsoXmlTag("PrcgId")]
    public IsoMax35Text? ProcessingIdentification { get; init; }
}
