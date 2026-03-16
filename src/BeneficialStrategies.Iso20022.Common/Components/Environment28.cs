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
[IsoId("_REazYY2gEeuUX8RS9eNYdA")]
[DisplayName("Environment")]
public record Environment28
{
    /// <summary>
    /// Party in contract with an acceptor to acquire card payment transactions.
    /// </summary>
    [IsoId("_RLbaUY2gEeuUX8RS9eNYdA")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public PartyIdentification263? Acquirer { get; init; }

    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_i0SHYI2gEeuUX8RS9eNYdA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// </summary>
    [IsoId("_RLbaU42gEeuUX8RS9eNYdA")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the originator or another intermediary agent.
    /// </summary>
    [IsoId("_RLbaVY2gEeuUX8RS9eNYdA")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; }

    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_lL2bsY2gEeuUX8RS9eNYdA")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; }

    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_WE8d8UYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_RLbaV42gEeuUX8RS9eNYdA")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData8? Card { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_RLbaW42gEeuUX8RS9eNYdA")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; }

    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_RLbaWY2gEeuUX8RS9eNYdA")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder19? Cardholder { get; init; }
}
