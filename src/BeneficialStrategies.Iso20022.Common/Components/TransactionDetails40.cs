// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the details of the transaction.
/// </summary>
[IsoId("_0cOiJAlIEeGATtfOBToyew_-2009352328")]
[DisplayName("Transaction Details")]
public record TransactionDetails40
{
    /// <summary>
    /// Way(s) of identifying the security.
    /// </summary>
    [IsoId("_0cOiJQlIEeGATtfOBToyew_-2139373112")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification14 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_0cOiJglIEeGATtfOBToyew_1928585592")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, eg, against payment.
    /// </summary>
    [IsoId("_0cOiJwlIEeGATtfOBToyew_130918167")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_0cXsEAlIEeGATtfOBToyew_1405908501")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required Quantity6Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_0cXsEQlIEeGATtfOBToyew_-119341130")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public required SecuritiesAccount13 SafekeepingAccount { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_0cXsEglIEeGATtfOBToyew_1973834836")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection8? SettlementAmount { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_0cXsEwlIEeGATtfOBToyew_-21401876")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate2Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_0cXsFAlIEeGATtfOBToyew_-490209291")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate1Choice_? TradeDate { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_0cXsFQlIEeGATtfOBToyew_1487645541")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties13? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_0chdEAlIEeGATtfOBToyew_1256529438")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties13? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_0chdEQlIEeGATtfOBToyew_206515420")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification37Choice_? Investor { get; init; }
}
