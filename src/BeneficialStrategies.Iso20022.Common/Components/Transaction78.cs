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
[IsoId("_9cb1wVycEeeve7Je9cXtkQ")]
[DisplayName("Transaction")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Transaction78
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a Transaction78 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public Transaction78( System.String reqTransactionType,TransactionIdentification8 reqTransactionIdentification,TransactionAmounts1 reqTransactionAmounts )
    {
        TransactionType = reqTransactionType;
        TransactionIdentification = reqTransactionIdentification;
        TransactionAmounts = reqTransactionAmounts;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Type of transaction associated with the main service
    /// ISO 8583:87/93/2003 bit 3
    /// </summary>
    [IsoId("_ESknKFydEeeve7Je9cXtkQ")]
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
    [IsoId("_2gPgYRqjEeqH1IQNpbVpEw")]
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
    [IsoId("_XxQqYUNNEeiut6dbx3wnBg")]
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
    [IsoId("_XxQqYkNNEeiut6dbx3wnBg")]
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
    /// Contains the period (expressed in minutes) within which a merchant is expected to complete the transaction.
    /// </summary>
    [IsoId("_aClQoYkFEeiUdscb3zN7pw")]
    [DisplayName("Pre Authorisation Time Limit")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PreAuthstnTmLmt")]
    #endif
    [IsoXmlTag("PreAuthstnTmLmt")]
    [IsoSimpleType(IsoSimpleType.Max6NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax6NumericText? PreAuthorisationTimeLimit { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? PreAuthorisationTimeLimit { get; init; } 
    #else
    public System.String? PreAuthorisationTimeLimit { get; set; } 
    #endif
    
    /// <summary>
    /// Destination value to be used in the subsequent addendum message.
    /// </summary>
    [IsoId("_60_HkekVEemeDPHh-U9b6w")]
    [DisplayName("Associated Data Destination")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AssoctdDataDstn")]
    #endif
    [IsoXmlTag("AssoctdDataDstn")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? AssociatedDataDestination { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AssociatedDataDestination { get; init; } 
    #else
    public System.String? AssociatedDataDestination { get; set; } 
    #endif
    
    /// <summary>
    /// Data to qualify for incentive or other related programmes.
    /// </summary>
    [IsoId("_9qHsd1ycEeeve7Je9cXtkQ")]
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
    /// Identification of the transaction
    /// </summary>
    [IsoId("_9qHseVycEeeve7Je9cXtkQ")]
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
    [IsoId("_9qHse1ycEeeve7Je9cXtkQ")]
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
    [IsoId("_ZvrdURb3Eeit0dtP9bTmEg")]
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
    [IsoId("_a09BURcNEeit0dtP9bTmEg")]
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
    [IsoId("_diJaEUKAEeiEPYf_NDteSA")]
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
    /// Balance of the account involved in the card transaction.
    /// </summary>
    [IsoId("_9qHsfVycEeeve7Je9cXtkQ")]
    [DisplayName("Account Balance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AcctBal")]
    #endif
    [IsoXmlTag("AcctBal")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AccountBalance1? AccountBalance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AccountBalance1? AccountBalance { get; init; } 
    #else
    public AccountBalance1? AccountBalance { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies a customer account or a relationship to its account affected for debit, inquiries and the source of funding for transfers.
    /// </summary>
    [IsoId("_9qHsgVycEeeve7Je9cXtkQ")]
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
    [IsoId("_9qHsg1ycEeeve7Je9cXtkQ")]
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
    [IsoId("_vQdVsJcoEeel1pCh5hkJPA")]
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
    [IsoId("_9KQ2cRqlEeqH1IQNpbVpEw")]
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
