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
[IsoId("_3WK3YdTLEeKvJeoOII0e7w")]
[DisplayName("Settlement Parties")]
public record SettlementParties32
{
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the central securities depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
    /// </summary>
    [IsoId("_3tE7idTLEeKvJeoOII0e7w")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public required PartyIdentification63 Depository { get; init; }

    /// <summary>
    /// Party that, in a settlement chain, interacts with the depository. This may also be known as the “local agent”, “sub-custodian”, “receiving agent” or “delivering agent”.
    /// </summary>
    [IsoId("_3tE7kdTLEeKvJeoOII0e7w")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount95? Party1 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain, interacts with party 1. This may also be known as the “investment manager” or “custodian”.
    /// </summary>
    [IsoId("_3tE7mdTLEeKvJeoOII0e7w")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount95? Party2 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain, interacts with party 2.
    /// </summary>
    [IsoId("_3tE7s9TLEeKvJeoOII0e7w")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount95? Party3 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain, interacts with party 3.
    /// </summary>
    [IsoId("_3tE7x9TLEeKvJeoOII0e7w")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty4")]
    public PartyIdentificationAndAccount95? Party4 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain, interacts with party 4.
    /// </summary>
    [IsoId("_3tE71dTLEeKvJeoOII0e7w")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty5")]
    public PartyIdentificationAndAccount95? Party5 { get; init; }
}
