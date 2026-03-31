// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Chain of parties involved in the settlement of a transaction, including receipts and deliveries, book transfers, treasury deals, or other activities, resulting in the movement of a security or amount of money from one account to another.
/// </summary>
[IsoId("_0fzamAlIEeGATtfOBToyew_1078318702")]
[DisplayName("Settlement Parties")]
public record SettlementParties26
{
    /// <summary>
    /// Party that, in a settlement chain interacts with the party 1.
    /// </summary>
    [IsoId("_0f8kgAlIEeGATtfOBToyew_2022929891")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount42? Party2 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 2.
    /// </summary>
    [IsoId("_0f8kgQlIEeGATtfOBToyew_12973033")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount42? Party3 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 3.
    /// </summary>
    [IsoId("_0f8kgglIEeGATtfOBToyew_338090540")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty4")]
    public PartyIdentificationAndAccount42? Party4 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 4.
    /// </summary>
    [IsoId("_0f8kgwlIEeGATtfOBToyew_2013156681")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty5")]
    public PartyIdentificationAndAccount42? Party5 { get; init; }
}
