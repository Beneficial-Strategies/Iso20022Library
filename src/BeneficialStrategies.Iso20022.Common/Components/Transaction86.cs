// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains transaction details.
/// </summary>
[IsoId("_2nbm4UQJEeiFlYmBVFSxUw")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction86
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction86 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction86( System.String reqTransactionType,TransactionIdentification8 reqTransactionIdentification,TransactionAmounts1 reqTransactionAmounts )
    {
        TransactionType = reqTransactionType;
        TransactionIdentification = reqTransactionIdentification;
        TransactionAmounts = reqTransactionAmounts;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of transaction associated with the main service.
    /// ISO 8583:87/93/2003 bit 3
    /// </summary>
    [IsoId("_2y4o8UQJEeiFlYmBVFSxUw")]
    [DisplayName("Transaction Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxTp")]
    #endif
    [IsoXmlTag("TxTp")]
    [IsoSimpleType(IsoSimpleType.Exact2AlphaNumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoExact2AlphaNumericText TransactionType { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String TransactionType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String TransactionType { get; init; } 
    #else
    public System.String TransactionType { get; set; } 
    #endif
    
    /// <summary>
    /// Provides further granularity of purpose of TransactionType
    /// </summary>
    [IsoId("_buvXURqkEeqH1IQNpbVpEw")]
    [DisplayName("Transaction Sub Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxSubTp")]
    #endif
    [IsoXmlTag("TxSubTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? TransactionSubType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionSubType { get; init; } 
    #else
    public System.String? TransactionSubType { get; set; } 
    #endif
    
    /// <summary>
    /// Attribute of the transaction.
    /// ISO 8583:87 bit 25
    /// ISO 8583:2003 bit 22-3 &amp; bit 24
    /// </summary>
    [IsoId("_2y4o9UQJEeiFlYmBVFSxUw")]
    [DisplayName("Transaction Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAttr")]
    #endif
    [IsoXmlTag("TxAttr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TransactionAttribute1Code? TransactionAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionAttribute1Code? TransactionAttribute { get; init; } 
    #else
    public TransactionAttribute1Code? TransactionAttribute { get; set; } 
    #endif
    
    /// <summary>
    /// Other transaction attribute defined at national or private level.
    /// </summary>
    [IsoId("_2y4o90QJEeiFlYmBVFSxUw")]
    [DisplayName("Other Transaction Attribute")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OthrTxAttr")]
    #endif
    [IsoXmlTag("OthrTxAttr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OtherTransactionAttribute { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OtherTransactionAttribute { get; init; } 
    #else
    public System.String? OtherTransactionAttribute { get; set; } 
    #endif
    
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_2y4o-UQJEeiFlYmBVFSxUw")]
    [DisplayName("Special Programme Qualification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SpclPrgrmmQlfctn")]
    #endif
    [IsoXmlTag("SpclPrgrmmQlfctn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; init; } 
    #else
    public SpecialProgrammeQualification1? SpecialProgrammeQualification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the transaction.
    /// </summary>
    [IsoId("_2y4o-0QJEeiFlYmBVFSxUw")]
    [DisplayName("Transaction Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxId")]
    #endif
    [IsoXmlTag("TxId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionIdentification8 TransactionIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionIdentification8 TransactionIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionIdentification8 TransactionIdentification { get; init; } 
    #else
    public TransactionIdentification8 TransactionIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts of the card transaction.
    /// </summary>
    [IsoId("_2y4o_UQJEeiFlYmBVFSxUw")]
    [DisplayName("Transaction Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxAmts")]
    #endif
    [IsoXmlTag("TxAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TransactionAmounts1 TransactionAmounts { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TransactionAmounts1 TransactionAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TransactionAmounts1 TransactionAmounts { get; init; } 
    #else
    public TransactionAmounts1 TransactionAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Amounts that are not part of the transaction amount and not included in reconciliation.
    /// ISO 8583 bit 54
    /// </summary>
    [IsoId("_2y4o_0QJEeiFlYmBVFSxUw")]
    [DisplayName("Additional Amounts")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlAmts")]
    #endif
    [IsoXmlTag("AddtlAmts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalAmounts1? AdditionalAmounts { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalAmounts1? AdditionalAmounts { get; init; } 
    #else
    public AdditionalAmounts1? AdditionalAmounts { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the transaction amount.
    /// </summary>
    [IsoId("_2y4pAUQJEeiFlYmBVFSxUw")]
    [DisplayName("Additional Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlFees")]
    #endif
    [IsoXmlTag("AddtlFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee1? AdditionalFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee1? AdditionalFees { get; init; } 
    #else
    public AdditionalFee1? AdditionalFees { get; set; } 
    #endif
    
    /// <summary>
    /// Fees not included in the original transaction amount.
    /// </summary>
    [IsoId("_2y4pA0QJEeiFlYmBVFSxUw")]
    [DisplayName("Original Additional Fees")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlAddtlFees")]
    #endif
    [IsoXmlTag("OrgnlAddtlFees")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalFee1? OriginalAdditionalFees { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalFee1? OriginalAdditionalFees { get; init; } 
    #else
    public AdditionalFee1? OriginalAdditionalFees { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_2y4pCUQJEeiFlYmBVFSxUw")]
    [DisplayName("Account From")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctFr")]
    #endif
    [IsoXmlTag("AcctFr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountDetails2? AccountFrom { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountDetails2? AccountFrom { get; init; } 
    #else
    public AccountDetails2? AccountFrom { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for credits, inquiries and the destination account for funds transfers.
    /// </summary>
    [IsoId("_2y4pC0QJEeiFlYmBVFSxUw")]
    [DisplayName("Account To")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctTo")]
    #endif
    [IsoXmlTag("AcctTo")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountDetails2? AccountTo { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountDetails2? AccountTo { get; init; } 
    #else
    public AccountDetails2? AccountTo { get; set; } 
    #endif
    
    /// <summary>
    /// Transaction data related to programmes and services, content and format based on bilateral agreements.
    /// </summary>
    [IsoId("_2y4pE0QJEeiFlYmBVFSxUw")]
    [DisplayName("Transaction Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TxDesc")]
    #endif
    [IsoXmlTag("TxDesc")]
    [IsoSimpleType(IsoSimpleType.Max1000Text)]
    [StringLength(maximumLength: 1000 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax1000Text? TransactionDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? TransactionDescription { get; init; } 
    #else
    public System.String? TransactionDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional data.
    /// </summary>
    [IsoId("_Eedc0RqmEeqH1IQNpbVpEw")]
    [DisplayName("Additional Data")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlData")]
    #endif
    [IsoXmlTag("AddtlData")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AdditionalData1? AdditionalData { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AdditionalData1? AdditionalData { get; init; } 
    #else
    public AdditionalData1? AdditionalData { get; set; } 
    #endif
    
    
    #nullable disable
    
}
