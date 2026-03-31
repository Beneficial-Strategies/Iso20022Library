// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Party Report4.
/// </summary>
[IsoId("_YQZ9YTE_Ee62xuUQ2zyZww")]
[DisplayName("Party Report4")]
public record PartyReport4
{
    /// <summary>
    /// Party Identification.
    /// </summary>
    [DisplayName("Party Identification")]
    [IsoXmlTag("PtyId")]
    public required SystemPartyIdentification8 PartyIdentification { get; init; }

    /// <summary>
    /// Party Or Error.
    /// </summary>
    [DisplayName("Party Or Error")]
    [IsoXmlTag("PtyOrErr")]
    public required PartyOrBusinessError4Choice_ PartyOrError { get; init; }
}
