// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Transaction163.
/// </summary>
[IsoId("_ISAsEYYQEe-Pv9KR9bv9IA")]
[DisplayName("Transaction163")]
public record Transaction163
{
    /// <summary>
    /// Account Owner Transaction Identification.
    /// </summary>
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required Max35Text AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Account Servicer Transaction Identification.
    /// </summary>
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public Max35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Market Infrastructure Transaction Identification.
    /// </summary>
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public Max35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Counterparty Market Infrastructure Transaction Identification.
    /// </summary>
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
    public Max35Text? CounterpartyMarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Processor Transaction Identification.
    /// </summary>
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public Max35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Trade Identification.
    /// </summary>
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public Max35Text? TradeIdentification { get; init; }

    /// <summary>
    /// Unique Transaction Identifier.
    /// </summary>
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public UTIIdentifier? UniqueTransactionIdentifier { get; init; }

    /// <summary>
    /// Pool Identification.
    /// </summary>
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public Max35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Common Identification.
    /// </summary>
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public Max35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Corporate Action Event Identification.
    /// </summary>
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public Max35Text? CorporateActionEventIdentification { get; init; }

    /// <summary>
    /// Triparty Agent Service Provider Collateral Transaction Identification.
    /// </summary>
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    public Max35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Client Triparty Collateral Transaction Identification.
    /// </summary>
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    public Max35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    /// <summary>
    /// Client Collateral Instruction Identification.
    /// </summary>
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    public Max35Text? ClientCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Triparty Agent Service Provider Collateral Instruction Identification.
    /// </summary>
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
    public Max35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; }

    /// <summary>
    /// Transaction Details.
    /// </summary>
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails170? TransactionDetails { get; init; }

    /// <summary>
    /// Status And Reason.
    /// </summary>
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public ValueList<Status38Choice_> StatusAndReason { get; init; } = [];
}
