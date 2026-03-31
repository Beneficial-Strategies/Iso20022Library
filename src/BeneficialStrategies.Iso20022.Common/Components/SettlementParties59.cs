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
[IsoId("_1D0EgY-1Eeaoj_JbcpWKgg")]
[DisplayName("Settlement Parties")]
public record SettlementParties59
{
    /// <summary>
    /// First party in the settlement chain. In a plain vanilla settlement, it is the Central Securities Depository where the counterparty requests to receive the financial instrument or from where the counterparty delivers the financial instruments.
    /// </summary>
    [IsoId("_1S_I_Y-1Eeaoj_JbcpWKgg")]
    [DisplayName("Depository")]
    [IsoXmlTag("Dpstry")]
    public PartyIdentification118? Depository { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the depository.
    /// </summary>
    [IsoId("_1S_JBY-1Eeaoj_JbcpWKgg")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty1")]
    public PartyIdentificationAndAccount155? Party1 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 1.
    /// </summary>
    [IsoId("_1S_JDY-1Eeaoj_JbcpWKgg")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty2")]
    public PartyIdentificationAndAccount155? Party2 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 2.
    /// </summary>
    [IsoId("_1S_JJ4-1Eeaoj_JbcpWKgg")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty3")]
    public PartyIdentificationAndAccount155? Party3 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 3.
    /// </summary>
    [IsoId("_1S_JO4-1Eeaoj_JbcpWKgg")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty4")]
    public PartyIdentificationAndAccount155? Party4 { get; init; }

    /// <summary>
    /// Party that, in a settlement chain interacts with the party 4.
    /// </summary>
    [IsoId("_1S_JSY-1Eeaoj_JbcpWKgg")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty5")]
    public PartyIdentificationAndAccount155? Party5 { get; init; }
}
