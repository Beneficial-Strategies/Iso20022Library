// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Information about a related settlement instruction.
/// </summary>
[IsoId("_l77MsLbjEe-NMoTZ6Byg6A")]
[DisplayName("Related Settlement Instruction3")]
public record RelatedSettlementInstruction3
{
    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository.
    /// </summary>
    [IsoId("_7U25IbbjEe-NMoTZ6Byg6A")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction.
    /// </summary>
    [IsoId("_NPJ7gbbkEe-NMoTZ6Byg6A")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Unique Transaction Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_34k1QN8AEe-NrtAAlrBEgQ")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Unambiguous identification of the related settlement instruction assigned by the account holder.
    /// </summary>
    [IsoId("_VkcygbbkEe-NMoTZ6Byg6A")]
    [DisplayName("Related Settlement Instruction Identification")]
    [IsoXmlTag("RltdSttlmInstrId")]
    public IsoMax35Text? RelatedSettlementInstructionIdentification { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_l4m9grbkEe-NMoTZ6Byg6A")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled.
    /// </summary>
    [IsoId("_B5iRp7blEe-NMoTZ6Byg6A")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Specifies the date/time on which the trade was executed.
    /// </summary>
    [IsoId("_KZVIcrblEe-NMoTZ6Byg6A")]
    [DisplayName("Trade Date")]
    [IsoXmlTag("TradDt")]
    public TradeDate8Choice_? TradeDate { get; init; }

    /// <summary>
    /// Date and time at which the securities are to be delivered or received.
    /// </summary>
    [IsoId("_Tz9P0rblEe-NMoTZ6Byg6A")]
    [DisplayName("Settlement Date")]
    [IsoXmlTag("SttlmDt")]
    public required SettlementDate17Choice_ SettlementDate { get; init; }

    /// <summary>
    /// Total quantity of securities to be settled.
    /// </summary>
    [IsoId("_XLSYBLblEe-NMoTZ6Byg6A")]
    [DisplayName("Settlement Quantity")]
    [IsoXmlTag("SttlmQty")]
    public required Quantity51Choice_ SettlementQuantity { get; init; }

    /// <summary>
    /// Total amount of money to be paid or received in exchange for the securities.
    /// </summary>
    [IsoId("_habQEbbmEe-NMoTZ6Byg6A")]
    [DisplayName("Settlement Amount")]
    [IsoXmlTag("SttlmAmt")]
    public AmountAndDirection110? SettlementAmount { get; init; }

    /// <summary>
    /// First receiving party in the settlement chain.
    /// </summary>
    [IsoId("_QCO_xLbnEe-NMoTZ6Byg6A")]
    [DisplayName("Counterparty Depository")]
    [IsoXmlTag("CtrPtyDpstry")]
    public PartyIdentification143? CounterpartyDepository { get; init; }
}
