// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the transaction.
/// </summary>
[IsoId("_oVV_S5aPEfC2_67yGLymgA")]
[DisplayName("Transaction167")]
public record Transaction167
{
    [IsoId("_oXVjQ5aPEfC2_67yGLymgA")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; }

    [IsoId("_oXVjR5aPEfC2_67yGLymgA")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    [IsoId("_oXVjS5aPEfC2_67yGLymgA")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("_oXVjT5aPEfC2_67yGLymgA")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
    public IsoMax35Text? CounterpartyMarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("_oXVjUZaPEfC2_67yGLymgA")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    [IsoId("_oXVjU5aPEfC2_67yGLymgA")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    [IsoId("_oXVjV5aPEfC2_67yGLymgA")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    [IsoId("_oXVjWZaPEfC2_67yGLymgA")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public IsoMax35Text? PoolIdentification { get; init; }

    [IsoId("_oXVjXZaPEfC2_67yGLymgA")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    [IsoId("_oXVjYZaPEfC2_67yGLymgA")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    [IsoId("_oXVjZZaPEfC2_67yGLymgA")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    [IsoId("_oXVjaZaPEfC2_67yGLymgA")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    [IsoId("_oXVjbZaPEfC2_67yGLymgA")]
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; }

    [IsoId("_oXVjb5aPEfC2_67yGLymgA")]
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; }

    [IsoId("_oXVjcZaPEfC2_67yGLymgA")]
    [DisplayName("Master Reference")]
    [IsoXmlTag("MstrRef")]
    public IsoMax35Text? MasterReference { get; init; }

    [IsoId("_oXVjc5aPEfC2_67yGLymgA")]
    [DisplayName("Client Reference")]
    [IsoXmlTag("ClntRef")]
    public AdditionalReference10? ClientReference { get; init; }

    [IsoId("_oXVjdZaPEfC2_67yGLymgA")]
    [DisplayName("Account Owner Leg Identification")]
    [IsoXmlTag("AcctOwnrLegId")]
    public IsoMax35Text? AccountOwnerLegIdentification { get; init; }

    [IsoId("_oXVjd5aPEfC2_67yGLymgA")]
    [DisplayName("Account Servicer Leg Identification")]
    [IsoXmlTag("AcctSvcrLegId")]
    public IsoMax35Text? AccountServicerLegIdentification { get; init; }

    [IsoId("_oXVjeZaPEfC2_67yGLymgA")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails184? TransactionDetails { get; init; }

    [IsoId("_oXVjfZaPEfC2_67yGLymgA")]
    [DisplayName("Supplementary Data")]
    [IsoXmlTag("SplmtryData")]
    public ValueList<SupplementaryData1> SupplementaryData { get; init; } = [];
}
