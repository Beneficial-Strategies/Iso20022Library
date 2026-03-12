// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
[IsoId("_2nbm4UQJEeiFlYmBVFSxUw")]
[DisplayName("Transaction")]
public partial record Transaction86
{
    #nullable enable
    
    /// <summary>
    /// Type of transaction associated with the main service.
    /// ISO 8583:87/93/2003 bit 3
    /// </summary>
    [IsoId("_2y4o8UQJEeiFlYmBVFSxUw")]
    [DisplayName("Transaction Type")]
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    public required IsoExact2AlphaNumericText TransactionType { get; init; } 
    
    /// <summary>
    /// Provides further granularity of purpose of TransactionType
    /// </summary>
    [IsoId("_buvXURqkEeqH1IQNpbVpEw")]
    [DisplayName("Transaction Sub Type")]
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? TransactionSubType { get; init; } 
    
    /// <summary>
    /// Attribute of the transaction.
    /// ISO 8583:87 bit 25
    /// ISO 8583:2003 bit 22-3 &amp; bit 24
    /// </summary>
    [IsoId("_2y4o9UQJEeiFlYmBVFSxUw")]
    [DisplayName("Transaction Attribute")]
    [IsoXmlTag("TxAttr")]
    public TransactionAttribute1Code? TransactionAttribute { get; init; } 
    
    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    [IsoId("_2y4o90QJEeiFlYmBVFSxUw")]
    [DisplayName("Other Transaction Attribute")]
    [IsoXmlTag("OthrTxAttr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherTransactionAttribute { get; init; } 
    
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_2y4o-UQJEeiFlYmBVFSxUw")]
    [DisplayName("Special Programme Qualification")]
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; } 
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_2y4o-0QJEeiFlYmBVFSxUw")]
    [DisplayName("Transaction Identification")]
    [IsoXmlTag("TxId")]
    public required TransactionIdentification8 TransactionIdentification { get; init; } 
    
    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_2y4o_UQJEeiFlYmBVFSxUw")]
    [DisplayName("Transaction Amounts")]
    [IsoXmlTag("TxAmts")]
    public required TransactionAmounts1 TransactionAmounts { get; init; } 
    
    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// ISO 8583 bit 54
    /// </summary>
    [IsoId("_2y4o_0QJEeiFlYmBVFSxUw")]
    [DisplayName("Additional Amounts")]
    [IsoXmlTag("AddtlAmts")]
    public AdditionalAmounts1? AdditionalAmounts { get; init; } 
    
    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_2y4pAUQJEeiFlYmBVFSxUw")]
    [DisplayName("Additional Fees")]
    [IsoXmlTag("AddtlFees")]
    public AdditionalFee1? AdditionalFees { get; init; } 
    
    /// <summary>
    /// Fees not included in the original transaction amount.
    /// </summary>
    [IsoId("_2y4pA0QJEeiFlYmBVFSxUw")]
    [DisplayName("Original Additional Fees")]
    [IsoXmlTag("OrgnlAddtlFees")]
    public AdditionalFee1? OriginalAdditionalFees { get; init; } 
    
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_2y4pCUQJEeiFlYmBVFSxUw")]
    [DisplayName("Account From")]
    [IsoXmlTag("AcctFr")]
    public AccountDetails2? AccountFrom { get; init; } 
    
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_2y4pC0QJEeiFlYmBVFSxUw")]
    [DisplayName("Account To")]
    [IsoXmlTag("AcctTo")]
    public AccountDetails2? AccountTo { get; init; } 
    
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_2y4pE0QJEeiFlYmBVFSxUw")]
    [DisplayName("Transaction Description")]
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    public IsoMax1000Text? TransactionDescription { get; init; } 
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_Eedc0RqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public AdditionalData1? AdditionalData { get; init; } 
    
    
    #nullable disable
    
}
