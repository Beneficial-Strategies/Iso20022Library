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
[IsoId("_SKZ4jSAaEeu4a6pNulzZ4Q")]
[DisplayName("Transaction Details")]
public record TransactionDetails139
{
    /// <summary>
    /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
    /// </summary>
    [IsoId("_SKZ4kSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Financial Instrument Identification")]
    [IsoXmlTag("FinInstrmId")]
    public required SecurityIdentification20 FinancialInstrumentIdentification { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_SKZ4mSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate9Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_SKZ4oSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate20Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_SKZ4qSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required Quantity10Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_SKZ4sSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection67? SettlementAmount { get; init; }

    /// <summary>
    /// Identifies the chain of delivering settlement parties.
    /// </summary>
    [IsoId("_SKZ4uSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Delivering Settlement Parties")]
    [IsoXmlTag("DlvrgSttlmPties")]
    public SettlementParties90? DeliveringSettlementParties { get; init; }

    /// <summary>
    /// Identifies the chain of receiving settlement parties.
    /// </summary>
    [IsoId("_SKZ4wSAaEeu4a6pNulzZ4Q")]
    [DisplayName("Receiving Settlement Parties")]
    [IsoXmlTag("RcvgSttlmPties")]
    public SettlementParties90? ReceivingSettlementParties { get; init; }

    /// <summary>
    /// Party, either an individual or organisation, whose assets are being invested.
    /// </summary>
    [IsoId("_SKZ4ySAaEeu4a6pNulzZ4Q")]
    [DisplayName("Investor")]
    [IsoXmlTag("Invstr")]
    public PartyIdentification170? Investor { get; init; }
}
