// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("__fnW8anWEfC5VNwixU6YfQ")]
[DisplayName("Party Identification338")]
public record PartyIdentification338
{
    /// <summary>
    /// Identification of a legal entity.
    /// </summary>
    [IsoId("__m-jManWEfC5VNwixU6YfQ")]
    [DisplayName("Legal Person")]
    [IsoXmlTag("LglPrsn")]
    public PartyIdentification335Choice? LegalPerson { get; init; }

    /// <summary>
    /// Instruction blocking reference allocated by the ICSD to be transmitted to the issuer.
    /// </summary>
    [IsoId("_f8eq4KnXEfC5VNwixU6YfQ")]
    [DisplayName("Blocking Reference")]
    [IsoXmlTag("BlckgRef")]
    public IsoMax35Text? BlockingReference { get; init; }
}
