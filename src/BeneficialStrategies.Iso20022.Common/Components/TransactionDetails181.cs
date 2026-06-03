// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies the securities settlement transaction.
/// </summary>
[IsoId("_W8lgcZaLEfC2_67yGLymgA")]
[DisplayName("Transaction Details181")]
public record TransactionDetails181
{
    [IsoId("_W8lgcZaLEfC2_67yGLymgB")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required SettlementTypeAndIdentification18 AccountOwnerTransactionIdentification { get; init; }

    [IsoId("_W8lgcZaLEfC2_67yGLymgC")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    [IsoId("_W8lgcZaLEfC2_67yGLymgD")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    [IsoId("_W8lgcZaLEfC2_67yGLymgE")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    [IsoId("_W8lgcZaLEfC2_67yGLymgF")]
    [DisplayName("Other Transaction Identification")]
    [IsoXmlTag("OthrTxId")]
    public IsoMax35Text? OtherTransactionIdentification { get; init; }

    [IsoId("_W8lgcZaLEfC2_67yGLymgG")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    [IsoId("_W8lgcZaLEfC2_67yGLymgH")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    [IsoId("_W8lgcZaLEfC2_67yGLymgI")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    [IsoId("_W8lgcZaLEfC2_67yGLymgJ")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails180? TransactionDetails { get; init; }
}
