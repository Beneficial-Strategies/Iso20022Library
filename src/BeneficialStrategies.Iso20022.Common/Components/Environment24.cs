// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Environment of the transaction for Inquiry.
/// </summary>
[IsoId("_TAJ1wYaZEeuSbct6WWD-Ng")]
[DisplayName("Environment")]
public record Environment24
{
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_TEe8IYaZEeuSbct6WWD-Ng")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification263 Acquirer { get; init; }

    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_xj09oY2jEeuUX8RS9eNYdA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_TEfjMYaZEeuSbct6WWD-Ng")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_TEfjM4aZEeuSbct6WWD-Ng")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; }

    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_TEfjNYaZEeuSbct6WWD-Ng")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public required PartyIdentification255 Acceptor { get; init; }

    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_zAwOoY2jEeuUX8RS9eNYdA")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; }

    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_TEfjN4aZEeuSbct6WWD-Ng")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal6? Terminal { get; init; }

    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_ObYrkUYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_TEfjOYaZEeuSbct6WWD-Ng")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required CardData9 Card { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_TEfjO4aZEeuSbct6WWD-Ng")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet2? Wallet { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_TEfjPYaZEeuSbct6WWD-Ng")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; }

    /// <summary>
    /// Information about the cardholder.
    /// </summary>
    [IsoId("_O5CkYCbUEeyhZIgCcGlTyA")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder19? Cardholder { get; init; }
}
