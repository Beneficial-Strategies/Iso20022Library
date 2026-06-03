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
[IsoId("_87zZoQNrEfG_3cM8uyJ20w")]
[DisplayName("Transaction169")]
public record Transaction169
{
    [IsoId("_8-YMgwNrEfG_3cM8uyJ20w")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public SystemPartyIdentification8? AccountOwner { get; init; }

    [IsoId("_8-YMhQNrEfG_3cM8uyJ20w")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    [IsoId("_8-YMhwNrEfG_3cM8uyJ20w")]
    [DisplayName("Status And Reason")]
    [IsoXmlTag("StsAndRsn")]
    public StatusAndReason52? StatusAndReason { get; init; }

    [IsoId("_8-YMjwNrEfG_3cM8uyJ20w")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; }

    [IsoId("_8-ZapQNrEfG_3cM8uyJ20w")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    [IsoId("_8-ZarQNrEfG_3cM8uyJ20w")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("_8-ZatQNrEfG_3cM8uyJ20w")]
    [DisplayName("Counterparty Market Infrastructure Transaction Identification")]
    [IsoXmlTag("CtrPtyMktInfrstrctrTxId")]
    public IsoMax35Text? CounterpartyMarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("_8-ZatwNrEfG_3cM8uyJ20w")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    [IsoId("_8-ZauQNrEfG_3cM8uyJ20w")]
    [DisplayName("Trade Identification")]
    [IsoXmlTag("TradId")]
    public SimpleValueList<IsoMax35Text> TradeIdentification { get; init; } = [];

    [IsoId("_lDxI4QjOEfGIV7JKjdGBTg")]
    [DisplayName("Unique Transaction Identifier")]
    [IsoXmlTag("UnqTxIdr")]
    public IsoUTIIdentifier? UniqueTransactionIdentifier { get; init; }

    [IsoId("_8-aBsQNrEfG_3cM8uyJ20w")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public IsoMax35Text? PoolIdentification { get; init; }

    [IsoId("_8-aoxQNrEfG_3cM8uyJ20w")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public IsoMax35Text? CommonIdentification { get; init; }

    [IsoId("_8-aozQNrEfG_3cM8uyJ20w")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }

    [IsoId("_8-ao1QNrEfG_3cM8uyJ20w")]
    [DisplayName("Client Collateral Instruction Identification")]
    [IsoXmlTag("ClntCollInstrId")]
    public IsoMax35Text? ClientCollateralInstructionIdentification { get; init; }

    [IsoId("_8-ao1wNrEfG_3cM8uyJ20w")]
    [DisplayName("Client Triparty Collateral Transaction Identification")]
    [IsoXmlTag("ClntTrptyCollTxId")]
    public IsoMax35Text? ClientTripartyCollateralTransactionIdentification { get; init; }

    [IsoId("_8-ao3wNrEfG_3cM8uyJ20w")]
    [DisplayName("Triparty Agent Service Provider Collateral Transaction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollTxId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralTransactionIdentification { get; init; }

    [IsoId("_8-ao4QNrEfG_3cM8uyJ20w")]
    [DisplayName("Triparty Agent Service Provider Collateral Instruction Identification")]
    [IsoXmlTag("TrptyAgtSvcPrvdrCollInstrId")]
    public IsoMax35Text? TripartyAgentServiceProviderCollateralInstructionIdentification { get; init; }

    [IsoId("_8-ao4wNrEfG_3cM8uyJ20w")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails187? TransactionDetails { get; init; }
}
