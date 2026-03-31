// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Parties124.
/// </summary>
[IsoId("_2qQyQYYPEe-9jM3-w7OB3g")]
[DisplayName("Settlement Parties124")]
public record SettlementParties124
{
    /// <summary>
    /// Depository.
    /// </summary>
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public required PartyIdentification316 Depository { get; init; }

    /// <summary>
    /// Party1.
    /// </summary>
    [DisplayName("Party1")]
    [IsoXmlTag("Pty1")]
    public required PartyIdentificationAndAccount163 Party1 { get; init; }

    /// <summary>
    /// Party2.
    /// </summary>
    [DisplayName("Party2")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount163? Party2 { get; init; }

    /// <summary>
    /// Party3.
    /// </summary>
    [DisplayName("Party3")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount163? Party3 { get; init; }
}
