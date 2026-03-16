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
[IsoId("_lCTLUYdDEeulCpwZAxK3Uw")]
[DisplayName("Environment")]
public record Environment25
{
    /// <summary>
    /// Party in a contractual relationship with an acceptor to acquire card payment transactions.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_lHyIQYdDEeulCpwZAxK3Uw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification263 Acquirer { get; init; }

    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_NbN5IYzREeutDIMngNCnkg")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_lHyIQ4dDEeulCpwZAxK3Uw")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_lHyIRYdDEeulCpwZAxK3Uw")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; }

    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_lHyIR4dDEeulCpwZAxK3Uw")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification256? Acceptor { get; init; }

    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_QEu5EYzREeutDIMngNCnkg")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; }

    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_lHyISYdDEeulCpwZAxK3Uw")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal6? Terminal { get; init; }

    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_Q6lR4UYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_lHyIS4dDEeulCpwZAxK3Uw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required CardData9 Card { get; init; }

    /// <summary>
    /// Identification of the customer device performing the transaction.
    /// </summary>
    [IsoId("_lHyITYdDEeulCpwZAxK3Uw")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice4? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_lHyIT4dDEeulCpwZAxK3Uw")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet2? Wallet { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_lHyIUYdDEeulCpwZAxK3Uw")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; }

    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_aaq0gCbUEeyhZIgCcGlTyA")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder19? Cardholder { get; init; }
}
