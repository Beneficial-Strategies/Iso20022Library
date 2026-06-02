// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Unique identifier of a document, message or transaction.
/// </summary>
[IsoId("_mYHwoaovEfCG2_q2WT-90w")]
[DisplayName("Identification32")]
public record Identification32
{
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_mavm1aovEfCG2_q2WT-90w")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("_mavm4aovEfCG2_q2WT-90w")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository.
    /// </summary>
    [IsoId("_mavm7aovEfCG2_q2WT-90w")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a counterparty transaction assigned by a market infrastructure other than a central securities depository.
    /// </summary>
    [IsoId("_mavm-aovEfCG2_q2WT-90w")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
    public IsoMax35Text? CounterpartyMarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction other than the account owner, the account servicer and the market infrastructure.
    /// </summary>
    [IsoId("_mavm_6ovEfCG2_q2WT-90w")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_mavnBaovEfCG2_q2WT-90w")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party.
    /// </summary>
    [IsoId("_mavnEaovEfCG2_q2WT-90w")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    /// <summary>
    /// Unique Transaction Identifier (UTI) as agreed with the other counterparty.
    /// </summary>
    [IsoId("_mavnHaovEfCG2_q2WT-90w")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Unique and unambiguous identifier for a group of individual transfers as assigned by the instructing party.
    /// </summary>
    [IsoId("_mavnH6ovEfCG2_q2WT-90w")]
    [DisplayName("Master Identification")]
    [IsoXmlTag("MstrId")]
    public IsoMax35Text? MasterIdentification { get; init; }

    /// <summary>
    /// Identification of a basket trade.
    /// </summary>
    [IsoId("_mavnK6ovEfCG2_q2WT-90w")]
    [DisplayName("Basket Identification")]
    [IsoXmlTag("BsktId")]
    public IsoMax35Text? BasketIdentification { get; init; }

    /// <summary>
    /// Reference identifying an index trade.
    /// </summary>
    [IsoId("_mavnN6ovEfCG2_q2WT-90w")]
    [DisplayName("Index Identification")]
    [IsoXmlTag("IndxId")]
    public IsoMax35Text? IndexIdentification { get; init; }

    /// <summary>
    /// Unique identifier for a list, as assigned by the trading party.
    /// </summary>
    [IsoId("_mavnQ6ovEfCG2_q2WT-90w")]
    [DisplayName("List Identification")]
    [IsoXmlTag("ListId")]
    public IsoMax35Text? ListIdentification { get; init; }

    /// <summary>
    /// Program reference which identifies a program trade.
    /// </summary>
    [IsoId("_mavnT6ovEfCG2_q2WT-90w")]
    [DisplayName("Program Identification")]
    [IsoXmlTag("PrgmId")]
    public IsoMax35Text? ProgramIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_mavnW6ovEfCG2_q2WT-90w")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public IsoMax35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_mavnZ6ovEfCG2_q2WT-90w")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }
}
