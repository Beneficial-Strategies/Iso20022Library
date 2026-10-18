// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification31.
/// </summary>
[IsoId("_7TptY4YREe-Pv9KR9bv9IA")]
[DisplayName("Identification31")]
public partial record Identification31
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
    /// Common Identification.
    /// </summary>
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    public Max35Text? CommonIdentification { get; init; }

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
    /// Master Identification.
    /// </summary>
    [DisplayName("Master Identification")]
    [IsoXmlTag("MstrId")]
    public Max35Text? MasterIdentification { get; init; }

    /// <summary>
    /// Basket Identification.
    /// </summary>
    [DisplayName("Basket Identification")]
    [IsoXmlTag("BsktId")]
    public Max35Text? BasketIdentification { get; init; }

    /// <summary>
    /// Index Identification.
    /// </summary>
    [DisplayName("Index Identification")]
    [IsoXmlTag("IndxId")]
    public Max35Text? IndexIdentification { get; init; }

    /// <summary>
    /// List Identification.
    /// </summary>
    [DisplayName("List Identification")]
    [IsoXmlTag("ListId")]
    public Max35Text? ListIdentification { get; init; }

    /// <summary>
    /// Program Identification.
    /// </summary>
    [DisplayName("Program Identification")]
    [IsoXmlTag("PrgmId")]
    public Max35Text? ProgramIdentification { get; init; }

    /// <summary>
    /// Pool Identification.
    /// </summary>
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    public Max35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Corporate Action Event Identification.
    /// </summary>
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    public Max35Text? CorporateActionEventIdentification { get; init; }
}
