// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
[IsoId("_9cb1wVycEeeve7Je9cXtkQ")]
[DisplayName("Transaction")]
public record Transaction78
{
    /// <summary>
    /// Type of transaction associated with the main service
    /// ISO 8583:87/93/2003 bit 3
    /// </summary>
    [IsoId("_ESknKFydEeeve7Je9cXtkQ")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    public required IsoExact2AlphaNumericText TransactionType { get; init; }

    /// <summary>
    /// Provides further granularity of purpose of TransactionType
    /// </summary>
    [IsoId("_2gPgYRqjEeqH1IQNpbVpEw")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TransactionSubType { get; init; }

    /// <summary>
    /// Attribute of the transaction.
    /// ISO 8583:87 bit 25
    /// ISO 8583:2003 bit 22-3 &amp; bit 24
    /// </summary>
    [IsoId("_XxQqYUNNEeiut6dbx3wnBg")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public TransactionAttribute1Code? TransactionAttribute { get; init; }

    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    [IsoId("_XxQqYkNNEeiut6dbx3wnBg")]
    [DisplayName("Other Transaction Attribute")]
    [IsoXmlTag("OthrTxAttr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? OtherTransactionAttribute { get; init; }

    /// <summary>
    /// Contains the period (expressed in minutes) within which a merchant is expected to complete the transaction.
    /// </summary>
    [IsoId("_aClQoYkFEeiUdscb3zN7pw")]
    [DisplayName("Pre Authorisation Time Limit")]
    [IsoXmlTag("PreAuthstnTmLmt")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    public IsoMax6NumericText? PreAuthorisationTimeLimit { get; init; }

    /// <summary>
    /// Destination value to be used in the subsequent addendum message.
    /// </summary>
    [IsoId("_60_HkekVEemeDPHh-U9b6w")]
    [DisplayName("Associated Data Destination")]
    [IsoXmlTag("AssoctdDataDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AssociatedDataDestination { get; init; }

    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_9qHsd1ycEeeve7Je9cXtkQ")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public ValueList<SpecialProgrammeQualification1> SpecialProgrammeQualification { get; init; } =
        [];

    /// <summary>
    /// Identification of the transaction
    /// </summary>
    [IsoId("_9qHseVycEeeve7Je9cXtkQ")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification8 TransactionIdentification { get; init; }

    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_9qHse1ycEeeve7Je9cXtkQ")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required TransactionAmounts1 TransactionAmounts { get; init; }

    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// ISO 8583 bit 54
    /// </summary>
    [IsoId("_ZvrdURb3Eeit0dtP9bTmEg")]
    [DisplayName("Additional Amounts")]
    [IsoXmlTag("AddtlAmts")]
    public ValueList<AdditionalAmounts1> AdditionalAmounts { get; init; } = [];

    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_a09BURcNEeit0dtP9bTmEg")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public ValueList<AdditionalFee1> AdditionalFees { get; init; } = [];

    /// <summary>
    /// Fees not included in the original transaction amount.
    /// </summary>
    [IsoId("_diJaEUKAEeiEPYf_NDteSA")]
    [DisplayName("Original Additional Fees")]
    [IsoXmlTag("OrgnlAddtlFees")]
    public ValueList<AdditionalFee1> OriginalAdditionalFees { get; init; } = [];

    /// <summary>
    /// Balance of the account involved in the card transaction.
    /// </summary>
    [IsoId("_9qHsfVycEeeve7Je9cXtkQ")]
    [DisplayName("Account Balance")]
    [IsoXmlTag("AcctBal")]
    public ValueList<AccountBalance1> AccountBalance { get; init; } = [];

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_9qHsgVycEeeve7Je9cXtkQ")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails2? AccountFrom { get; init; }

    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_9qHsg1ycEeeve7Je9cXtkQ")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails2? AccountTo { get; init; }

    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_vQdVsJcoEeel1pCh5hkJPA")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000, MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; }

    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_9KQ2cRqlEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];
}
