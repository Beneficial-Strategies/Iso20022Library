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
[IsoId("_lvvlhSp6EeyR9JrVGfaMKw")]
[DisplayName("Transaction Details")]
public record TransactionDetails150
{
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_mGZKZSp6EeyR9JrVGfaMKw")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    public required SettlementTypeAndIdentification18 AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("_mGZKZyp6EeyR9JrVGfaMKw")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_mGZKayp6EeyR9JrVGfaMKw")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of the transaction assigned by the processor of the instruction other than the account owner, the account servicer and the market infrastructure.
    /// </summary>
    [IsoId("_mGZKbyp6EeyR9JrVGfaMKw")]
    [DisplayName("Processor Transaction Identification")]
    [IsoXmlTag("PrcrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? ProcessorTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a transaction that cannot be identified using a standard reference element present in the message.
    /// </summary>
    [IsoId("_mGZKcSp6EeyR9JrVGfaMKw")]
    [DisplayName("Other Transaction Identification")]
    [IsoXmlTag("OthrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherTransactionIdentification { get; init; }

    /// <summary>
    /// Party that legally owns the account.
    /// </summary>
    [IsoId("_mGZKcyp6EeyR9JrVGfaMKw")]
    [DisplayName("Account Owner")]
    [IsoXmlTag("AcctOwnr")]
    public PartyIdentification144? AccountOwner { get; init; }

    /// <summary>
    /// Account to or from which a securities entry is made.
    /// </summary>
    [IsoId("_mGZKdSp6EeyR9JrVGfaMKw")]
    [DisplayName("Safekeeping Account")]
    [IsoXmlTag("SfkpgAcct")]
    public SecuritiesAccount19? SafekeepingAccount { get; init; }

    /// <summary>
    /// Blockchain address or wallet where digital assets are maintained. This is the equivalent of safekeeping account for digital assets.
    /// </summary>
    [IsoId("_Ofq2EyqNEeyR9JrVGfaMKw")]
    [DisplayName("Block Chain Address Or Wallet")]
    [IsoXmlTag("BlckChainAdrOrWllt")]
    public BlockChainAddressWallet3? BlockChainAddressOrWallet { get; init; }

    /// <summary>
    /// Provides additional details on the transaction which can not be included within the structured fields of the message.
    /// </summary>
    [IsoId("_mGZKdyp6EeyR9JrVGfaMKw")]
    [DisplayName("Transaction Details")]
    [IsoXmlTag("TxDtls")]
    public TransactionDetails151? TransactionDetails { get; init; }
}
