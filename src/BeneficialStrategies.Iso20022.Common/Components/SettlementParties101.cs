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
[IsoId("_00bcYSqLEeyR9JrVGfaMKw")]
[DisplayName("Settlement Parties")]
public record SettlementParties101
{
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
    /// </summary>
    [IsoId("_1MRUsSqLEeyR9JrVGfaMKw")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification146? Depository { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_1MRUuSqLEeyR9JrVGfaMKw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount199? Party1 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 1.
    /// </summary>
    [IsoId("_1MRUwSqLEeyR9JrVGfaMKw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount199? Party2 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 2.
    /// </summary>
    [IsoId("_1MRU2yqLEeyR9JrVGfaMKw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount199? Party3 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 3.
    /// </summary>
    [IsoId("_1MRU7yqLEeyR9JrVGfaMKw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty4")]
    public PartyIdentificationAndAccount199? Party4 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 4.
    /// </summary>
    [IsoId("_1MRU_SqLEeyR9JrVGfaMKw")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty5")]
    public PartyIdentificationAndAccount199? Party5 { get; init; }
}
