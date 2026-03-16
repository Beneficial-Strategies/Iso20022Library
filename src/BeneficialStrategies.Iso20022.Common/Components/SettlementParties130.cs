// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Parties130.
/// </summary>
[IsoId("_kv8Z75t3Ee-wQIOX0djF2w")]
[DisplayName("Settlement Parties130")]
public record SettlementParties130
{
    /// <summary>
    /// Depository.
    /// </summary>
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification318? Depository { get; init; }

    /// <summary>
    /// Party1.
    /// </summary>
    [DisplayName("Party1")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount205? Party1 { get; init; }

    /// <summary>
    /// Party2.
    /// </summary>
    [DisplayName("Party2")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount205? Party2 { get; init; }

    /// <summary>
    /// Party3.
    /// </summary>
    [DisplayName("Party3")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount205? Party3 { get; init; }
}
