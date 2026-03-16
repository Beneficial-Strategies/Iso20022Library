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
[IsoId("_P0mTQYEIEeu6D49Gi-ZPwQ")]
[DisplayName("Environment")]
public record Environment17
{
    /// <summary>
    /// Identification of the acquirer.
    /// </summary>
    [IsoId("_P6FQMYEIEeu6D49Gi-ZPwQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification263 Acquirer { get; init; }

    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_azT1QIzJEeujJfnIQ4NlpQ")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_P6FQM4EIEeu6D49Gi-ZPwQ")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_P6FQNYEIEeu6D49Gi-ZPwQ")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; }

    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_P6FQN4EIEeu6D49Gi-ZPwQ")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification255? Acceptor { get; init; }

    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_gbQ8QIzJEeujJfnIQ4NlpQ")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; }

    /// <summary>
    /// The party providing source of funds.
    /// </summary>
    [IsoId("_P6FQOYEIEeu6D49Gi-ZPwQ")]
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PartyIdentification257? Payer { get; init; }

    /// <summary>
    /// The party receiving funds.
    /// ISO 8583:87/93/2003 bit 98
    /// </summary>
    [IsoId("_P6FQO4EIEeu6D49Gi-ZPwQ")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PartyIdentification257? Payee { get; init; }

    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_P6FQPYEIEeu6D49Gi-ZPwQ")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal4? Terminal { get; init; }

    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_0cMQkEYsEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_P6FQP4EIEeu6D49Gi-ZPwQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public CardData6? Card { get; init; }

    /// <summary>
    /// Identification of the customer device performing the transaction.
    /// </summary>
    [IsoId("_P6FQQYEIEeu6D49Gi-ZPwQ")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice4? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_P6FQQ4EIEeu6D49Gi-ZPwQ")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet2? Wallet { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_P6FQRYEIEeu6D49Gi-ZPwQ")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; }

    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_P6FQR4EIEeu6D49Gi-ZPwQ")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder19? Cardholder { get; init; }
}
