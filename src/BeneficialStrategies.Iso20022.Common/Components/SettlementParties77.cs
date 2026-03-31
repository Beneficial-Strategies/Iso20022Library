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
[IsoId("_9jKak9LCEeiN28wlpBQScw")]
[DisplayName("Settlement Parties")]
public record SettlementParties77
{
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
    /// </summary>
    [IsoId("_91T6gdLCEeiN28wlpBQScw")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification146? Depository { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_91T6idLCEeiN28wlpBQScw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount169? Party1 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 1.
    /// </summary>
    [IsoId("_91T6kdLCEeiN28wlpBQScw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount169? Party2 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 2.
    /// </summary>
    [IsoId("_91T6q9LCEeiN28wlpBQScw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount169? Party3 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 3.
    /// </summary>
    [IsoId("_91T6v9LCEeiN28wlpBQScw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty4")]
    public PartyIdentificationAndAccount169? Party4 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 4.
    /// </summary>
    [IsoId("_91T6zdLCEeiN28wlpBQScw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty5")]
    public PartyIdentificationAndAccount169? Party5 { get; init; }
}
