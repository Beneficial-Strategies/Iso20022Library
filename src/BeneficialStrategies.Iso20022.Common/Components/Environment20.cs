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
[IsoId("_s6jY4YHQEeuwq_rv81SdXw")]
[DisplayName("Environment")]
public record Environment20
{
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_tAdzoYHQEeuwq_rv81SdXw")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public PartyIdentification263? Acquirer { get; init; }

    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_TCaAkIzQEeutDIMngNCnkg")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_tAdzo4HQEeuwq_rv81SdXw")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_tAdzpYHQEeuwq_rv81SdXw")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; }

    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_tAdzp4HQEeuwq_rv81SdXw")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification254? Acceptor { get; init; }

    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_YEqZgYzQEeutDIMngNCnkg")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; }

    /// <summary>
    /// The party providing source of funds.
    /// </summary>
    [IsoId("_tAdzqYHQEeuwq_rv81SdXw")]
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PartyIdentification257? Payer { get; init; }

    /// <summary>
    /// The party receiving funds.
    /// </summary>
    [IsoId("_tAdzq4HQEeuwq_rv81SdXw")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PartyIdentification257? Payee { get; init; }

    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_tAdzrYHQEeuwq_rv81SdXw")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal5? Terminal { get; init; }

    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_DxTHcUYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_tAdzr4HQEeuwq_rv81SdXw")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required CardData7 Card { get; init; }

    /// <summary>
    /// Identification of the customer device performing the transaction.
    /// </summary>
    [IsoId("_tAdzsYHQEeuwq_rv81SdXw")]
    [DisplayName("Customer Device")]
    [IsoXmlTag("CstmrDvc")]
    public CustomerDevice4? CustomerDevice { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_tAdzs4HQEeuwq_rv81SdXw")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet2? Wallet { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_tAdztYHQEeuwq_rv81SdXw")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; }

    /// <summary>
    /// Cardholder performing the card payment transaction.
    /// </summary>
    [IsoId("_tAdzt4HQEeuwq_rv81SdXw")]
    [DisplayName("Cardholder")]
    [IsoXmlTag("Crdhldr")]
    public Cardholder19? Cardholder { get; init; }
}
