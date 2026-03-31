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
[IsoId("_cxLx8ECMEeeXpbqDpLawug")]
[DisplayName("Environment")]
public record Environment6
{
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_nqpO0ECMEeeXpbqDpLawug")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public PartyIdentification198? Acquirer { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_yXUz8ECMEeeXpbqDpLawug")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification198? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_5M6LsECMEeeXpbqDpLawug")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification198? Receiver { get; init; }

    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_8miZ8ECMEeeXpbqDpLawug")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification199? Acceptor { get; init; }

    /// <summary>
    /// Person initiating a payment to the benefit of a payee.
    /// </summary>
    [IsoId("_Oa8PsECNEeeXpbqDpLawug")]
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PartyIdentification211? Payer { get; init; }

    /// <summary>
    /// Person to the benefit of whom a payment is performed.
    /// </summary>
    [IsoId("_QE_WsECNEeeXpbqDpLawug")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PartyIdentification211? Payee { get; init; }

    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_bB90QEqWEeenp6hmNprBHg")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal3? Terminal { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_0Z1wkEqYEeenp6hmNprBHg")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required CardData3 Card { get; init; }

    /// <summary>
    /// Identification of the customer device performing the transaction.
    /// </summary>
    [IsoId("_RrdQgEqZEeenp6hmNprBHg")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice2? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_VjLhEFHNEeeRzt0J6TBeaA")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet1? Wallet { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_tXZzIEqZEeenp6hmNprBHg")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token1? Token { get; init; }

    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_XQw2sEqaEeenp6hmNprBHg")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder15? Cardholder { get; init; }
}
