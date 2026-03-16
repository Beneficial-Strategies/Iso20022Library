// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction.
/// </summary>
[IsoId("_5naGYUQGEeiFlYmBVFSxUw")]
[DisplayName("Environment")]
public record Environment14
{
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_5y3IcUQGEeiFlYmBVFSxUw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification197 Acquirer { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_5y3Ic0QGEeiFlYmBVFSxUw")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification197? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_5y3IdUQGEeiFlYmBVFSxUw")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification197? Receiver { get; init; }

    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_5y3Id0QGEeiFlYmBVFSxUw")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification197? Acceptor { get; init; }

    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_5y3IfUQGEeiFlYmBVFSxUw")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal2? Terminal { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_5y3If0QGEeiFlYmBVFSxUw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required CardData5 Card { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_5y3Ig0QGEeiFlYmBVFSxUw")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token1? Token { get; init; }
}
