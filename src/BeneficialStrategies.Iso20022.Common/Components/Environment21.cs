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
[IsoId("_HRkWoYHWEeu7P-fjMhpKOg")]
[DisplayName("Environment")]
public record Environment21
{
    /// <summary>
    /// Identification of the acquirer.
    /// ISO 8583 bit 32.
    /// </summary>
    [IsoId("_HXG98YHWEeu7P-fjMhpKOg")]
    [DisplayName("Acquirer")]
    [IsoXmlTag("Acqrr")]
    public required PartyIdentification263 Acquirer { get; init; }

    /// <summary>
    /// Identifies the originator of the transaction.
    /// </summary>
    [IsoId("_ic2M4Y2iEeuUX8RS9eNYdA")]
    [DisplayName("Originator")]
    [IsoXmlTag("Orgtr")]
    public PartyIdentification263? Originator { get; init; }

    /// <summary>
    /// Party sending the message to another intermediary agent or to the final destination.
    /// ISO 8583 bit 33
    /// </summary>
    [IsoId("_HXG984HWEeu7P-fjMhpKOg")]
    [DisplayName("Sender")]
    [IsoXmlTag("Sndr")]
    public PartyIdentification263? Sender { get; init; }

    /// <summary>
    /// Party receiving the message from the origin or from an intermediary agent.
    /// ISO 8583 bit 100.
    /// </summary>
    [IsoId("_HXG99YHWEeu7P-fjMhpKOg")]
    [DisplayName("Receiver")]
    [IsoXmlTag("Rcvr")]
    public PartyIdentification263? Receiver { get; init; }

    /// <summary>
    /// Card acceptor performing the card transaction.
    /// </summary>
    [IsoId("_HXG994HWEeu7P-fjMhpKOg")]
    [DisplayName("Acceptor")]
    [IsoXmlTag("Accptr")]
    public PartyIdentification255? Acceptor { get; init; }

    /// <summary>
    /// Identifies the destination of the transaction.
    /// </summary>
    [IsoId("_j_8-YY2iEeuUX8RS9eNYdA")]
    [DisplayName("Destination")]
    [IsoXmlTag("Dstn")]
    public PartyIdentification263? Destination { get; init; }

    /// <summary>
    /// The party providing source of funds.
    /// </summary>
    [IsoId("_HXG9-YHWEeu7P-fjMhpKOg")]
    [DisplayName("Payer")]
    [IsoXmlTag("Pyer")]
    public PartyIdentification257? Payer { get; init; }

    /// <summary>
    /// The party receiving funds.
    /// </summary>
    [IsoId("_HXG9-4HWEeu7P-fjMhpKOg")]
    [DisplayName("Payee")]
    [IsoXmlTag("Pyee")]
    public PartyIdentification257? Payee { get; init; }

    /// <summary>
    /// Payment terminal or ATM performing the transaction.
    /// </summary>
    [IsoId("_HXG9_YHWEeu7P-fjMhpKOg")]
    [DisplayName("Terminal")]
    [IsoXmlTag("Termnl")]
    public Terminal6? Terminal { get; init; }

    /// <summary>
    /// Information related to the issuer.
    /// </summary>
    [IsoId("_GrYS8UYvEeydPZbwOuqbJQ")]
    [DisplayName("Issuer")]
    [IsoXmlTag("Issr")]
    public PartyIdentification263? Issuer { get; init; }

    /// <summary>
    /// Card or payment token performing the transaction.
    /// </summary>
    [IsoId("_HXG9_4HWEeu7P-fjMhpKOg")]
    [DisplayName("Card")]
    [IsoXmlTag("Card")]
    public required CardData10 Card { get; init; }

    /// <summary>
    /// Container for tenders used by the customer to perform the payment transaction.
    /// </summary>
    [IsoId("_HXG-AYHWEeu7P-fjMhpKOg")]
    [DisplayName("Wallet")]
    [IsoXmlTag("Wllt")]
    public Wallet2? Wallet { get; init; }

    /// <summary>
    /// Details of payment token.
    /// </summary>
    [IsoId("_HXG-A4HWEeu7P-fjMhpKOg")]
    [DisplayName("Token")]
    [IsoXmlTag("Tkn")]
    public Token2? Token { get; init; }
}
