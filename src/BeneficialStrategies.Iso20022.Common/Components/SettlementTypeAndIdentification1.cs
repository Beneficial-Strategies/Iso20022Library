// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides transaction type and identification information.
/// </summary>
[IsoId("_Ui6IjNp-Ed-ak6NoX_4Aeg_419282003")]
[DisplayName("Settlement Type And Identification")]
public record SettlementTypeAndIdentification1
{
    /// <summary>
    /// Unambiguous identification of the transaction as known by the account owner (or the instructing party managing the account).
    /// </summary>
    [IsoId("_UjDScNp-Ed-ak6NoX_4Aeg_305442937")]
    [DisplayName("Account Owner Transaction Identification")]
    [IsoXmlTag("AcctOwnrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text AccountOwnerTransactionIdentification { get; init; }

    /// <summary>
    /// Unambiguous identification of the transaction as known by the account servicer.
    /// </summary>
    [IsoId("_UjDScdp-Ed-ak6NoX_4Aeg_-691629416")]
    [DisplayName("Account Servicer Transaction Identification")]
    [IsoXmlTag("AcctSvcrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AccountServicerTransactionIdentification { get; init; }

    /// <summary>
    /// Identification of a transaction assigned by a market infrastructure other than a central securities depository, for example, Target2-Securities.
    /// </summary>
    [IsoId("_UjDSctp-Ed-ak6NoX_4Aeg_520139859")]
    [DisplayName("Market Infrastructure Transaction Identification")]
    [IsoXmlTag("MktInfrstrctrTxId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? MarketInfrastructureTransactionIdentification { get; init; }

    /// <summary>
    /// Specifies if the movement on a securities account results from a deliver or a receive instruction.
    /// </summary>
    [IsoId("_UjDSc9p-Ed-ak6NoX_4Aeg_216272914")]
    [DisplayName("Securities Movement Type")]
    [IsoXmlTag("SctiesMvmntTp")]
    public required ReceiveDelivery1Code SecuritiesMovementType { get; init; }

    /// <summary>
    /// Specifies how the transaction is to be settled, for example, against payment.
    /// </summary>
    [IsoId("_UjDSdNp-Ed-ak6NoX_4Aeg_1005114294")]
    [DisplayName("Payment")]
    [IsoXmlTag("Pmt")]
    public required DeliveryReceiptType2Code Payment { get; init; }

    /// <summary>
    /// Unique reference agreed upon by the two trade counterparties to identify the trade.
    /// </summary>
    [IsoId("_UjDSddp-Ed-ak6NoX_4Aeg_-1688701769")]
    [DisplayName("Common Identification")]
    [IsoXmlTag("CmonId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CommonIdentification { get; init; }

    /// <summary>
    /// Collective reference identifying a set of messages.
    /// </summary>
    [IsoId("_UjDSdtp-Ed-ak6NoX_4Aeg_-943443262")]
    [DisplayName("Pool Identification")]
    [IsoXmlTag("PoolId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? PoolIdentification { get; init; }

    /// <summary>
    /// Identification assigned by the account servicer to unambiguously identify a corporate action event.
    /// </summary>
    [IsoId("_UjDSd9p-Ed-ak6NoX_4Aeg_1918461782")]
    [DisplayName("Corporate Action Event Identification")]
    [IsoXmlTag("CorpActnEvtId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? CorporateActionEventIdentification { get; init; }
}
