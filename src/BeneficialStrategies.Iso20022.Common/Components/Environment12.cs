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
[IsoId("_d4BsgdXtEee5XtaG1wqDfQ")]
[DisplayName("Environment")]
public record Environment12
{
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_eGKPIdXtEee5XtaG1wqDfQ")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification197 Acquirer { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_eGKPI9XtEee5XtaG1wqDfQ")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification197? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_eGKPJdXtEee5XtaG1wqDfQ")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification197? Receiver { get; init; }

    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_eGKPJ9XtEee5XtaG1wqDfQ")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public required PartyIdentification203 Acceptor { get; init; }

    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_eGKPL9XtEee5XtaG1wqDfQ")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal1? Terminal { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_eGKPM9XtEee5XtaG1wqDfQ")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required CardData1 Card { get; init; }

    /// <summary>
    /// Identification of the customer device performing the transaction.
    /// </summary>
    [IsoId("_eGKPNdXtEee5XtaG1wqDfQ")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice2? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_eGKPN9XtEee5XtaG1wqDfQ")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet1? Wallet { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_eGKPOdXtEee5XtaG1wqDfQ")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token1? Token { get; init; }

    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_eGKPO9XtEee5XtaG1wqDfQ")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder15? Cardholder { get; init; }
}
