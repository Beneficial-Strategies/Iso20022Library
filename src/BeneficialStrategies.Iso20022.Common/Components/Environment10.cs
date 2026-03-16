// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment for a card transaction.
/// </summary>
[IsoId("_JYge4Xa3Eeef9c2nwgY9Xw")]
[DisplayName("Environment")]
public record Environment10
{
    /// <summary>
    /// Party in contract with an acceptor to acquire card payment transactions.
    /// </summary>
    [IsoId("_JkHR8Xa3Eeef9c2nwgY9Xw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public PartyIdentification197? Acquirer { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// </summary>
    [IsoId("_JkHR83a3Eeef9c2nwgY9Xw")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification197? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the originator or another intermediary agent.
    /// </summary>
    [IsoId("_JkHR9Xa3Eeef9c2nwgY9Xw")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification197? Receiver { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_JkHR_Xa3Eeef9c2nwgY9Xw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData3? Card { get; init; }

    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_FujtwZjGEeepepmc9PHSnw")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder15? Cardholder { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_44yhYN0bEeil7LQldntseg")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token1? Token { get; init; }
}
