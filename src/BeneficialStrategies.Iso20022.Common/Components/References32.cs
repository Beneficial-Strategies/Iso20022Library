// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides a set of identifications to reference to a securities settlement transaction.
/// </summary>
[IsoId("_Izn2geSmEe-qVZLXW4RRBw")]
[DisplayName("References32")]
public record References32
{
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner.
    /// </summary>
    [IsoId("_I8HEI-SmEe-qVZLXW4RRBw")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public IsoMax35Text? AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("_I8HEJ-SmEe-qVZLXW4RRBw")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository.
    /// </summary>
    [IsoId("_I8HEK-SmEe-qVZLXW4RRBw")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a counterparty transaction assigned by a market infrastructure other than a central securities depository.
    /// </summary>
    [IsoId("_5cLyceSlEe-qVZLXW4RRBw")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
    public IsoMax35Text? CounterpartyMarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction.
    /// </summary>
    [IsoId("_I8HEL-SmEe-qVZLXW4RRBw")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_I8HEMeSmEe-qVZLXW4RRBw")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public IsoMax35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_I8HENeSmEe-qVZLXW4RRBw")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Reference assigned to the trade by the investor or the trading party.
    /// </summary>
    [IsoId("_I8HEOeSmEe-qVZLXW4RRBw")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public IsoMax52Text? TradeIdentification { get; init; }
}
