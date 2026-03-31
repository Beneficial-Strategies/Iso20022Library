// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Settlement Parties125.
/// </summary>
[IsoId("_IQeNUYopEe-efPejSUAtLw")]
[DisplayName("Settlement Parties125")]
public record SettlementParties125
{
    /// <summary>
    /// Depository.
    /// </summary>
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification314? Depository { get; init; }

    /// <summary>
    /// Party1.
    /// </summary>
    [DisplayName("Party1")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount195? Party1 { get; init; }

    /// <summary>
    /// Party2.
    /// </summary>
    [DisplayName("Party2")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount195? Party2 { get; init; }

    /// <summary>
    /// Party3.
    /// </summary>
    [DisplayName("Party3")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount195? Party3 { get; init; }

    /// <summary>
    /// Party4.
    /// </summary>
    [DisplayName("Party4")]
    [IsoXmlTag("Pty4")]
    public PartyIdentificationAndAccount195? Party4 { get; init; }

    /// <summary>
    /// Party5.
    /// </summary>
    [DisplayName("Party5")]
    [IsoXmlTag("Pty5")]
    public PartyIdentificationAndAccount195? Party5 { get; init; }
}
