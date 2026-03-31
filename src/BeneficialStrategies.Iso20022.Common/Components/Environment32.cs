// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of a card transaction.
/// </summary>
[IsoId("_3_n-wZx9EeuwYeL1lHu9zw")]
[DisplayName("Environment")]
public record Environment32
{
    /// <summary>
    /// Party in a contractual relationship with an acceptor to acquire card payment transactions.
    /// </summary>
    [IsoId("_4GD98Zx9EeuwYeL1lHu9zw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification263 Acquirer { get; init; }

    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_4GD985x9EeuwYeL1lHu9zw")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// </summary>
    [IsoId("_4GD99Zx9EeuwYeL1lHu9zw")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// </summary>
    [IsoId("_4GD995x9EeuwYeL1lHu9zw")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; }

    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_4GD9-Zx9EeuwYeL1lHu9zw")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification258? Acceptor { get; init; }

    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_4GD9-5x9EeuwYeL1lHu9zw")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; }

    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_4GD9_Zx9EeuwYeL1lHu9zw")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal6? Terminal { get; init; }

    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_etPwgUYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_4GD9_5x9EeuwYeL1lHu9zw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData9? Card { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_4GD-AZx9EeuwYeL1lHu9zw")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet2? Wallet { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_4GD-A5x9EeuwYeL1lHu9zw")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token3? Token { get; init; }

    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_b2wYASbUEeyhZIgCcGlTyA")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder19? Cardholder { get; init; }
}
