// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
#if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
using System.ComponentModel.DataAnnotations;
#endif
namespace BeneficialStrategies.Iso20022.Choices.CardTransaction2Choice
{
    /// <summary>
    /// Card transaction details for the individual transaction, as recorded at the POI (point of interaction).
    /// </summary>
    [IsoId("_0jmr8zj3EeSz-s1QOUJaOg")]
    [DisplayName("Individual")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Individual : CardTransaction2Choice_
    #else
    public partial class Individual : CardTransaction2Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Data related to an integrated circuit card application.
        /// </summary>
        [IsoId("_vfHeYzj3EeSz-s1QOUJaOg")]
        [DisplayName("ICC Related Data")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="ICCRltdData")]
        #endif
        [IsoXmlTag("ICCRltdData")]
        [IsoSimpleType(IsoSimpleType.Max1025Text)]
        [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax1025Text? ICCRelatedData { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ICCRelatedData { get; init; } 
        #else
        public System.String? ICCRelatedData { get; set; } 
        #endif
        
        /// <summary>
        /// Context of the card payment transaction.
        /// </summary>
        [IsoId("_vfHeZDj3EeSz-s1QOUJaOg")]
        [DisplayName("Payment Context")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="PmtCntxt")]
        #endif
        [IsoXmlTag("PmtCntxt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PaymentContext3? PaymentContext { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PaymentContext3? PaymentContext { get; init; } 
        #else
        public PaymentContext3? PaymentContext { get; set; } 
        #endif
        
        /// <summary>
        /// Service in addition to the main service.
        /// </summary>
        [IsoId("_0yxwYTj3EeSz-s1QOUJaOg")]
        [DisplayName("Additional Service")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="AddtlSvc")]
        #endif
        [IsoXmlTag("AddtlSvc")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public CardPaymentServiceType2Code? AdditionalService { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public CardPaymentServiceType2Code? AdditionalService { get; init; } 
        #else
        public CardPaymentServiceType2Code? AdditionalService { get; set; } 
        #endif
        
        /// <summary>
        /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
        /// This element is also known as the MerchantCategoryCode.
        /// </summary>
        [IsoId("_0yxwYzj3EeSz-s1QOUJaOg")]
        [DisplayName("Transaction Category")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxCtgy")]
        #endif
        [IsoXmlTag("TxCtgy")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ExternalCardTransactionCategory1Code? TransactionCategory { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public string? TransactionCategory { get; init; } 
        #else
        public string? TransactionCategory { get; set; } 
        #endif
        
        /// <summary>
        /// Unique identification of the sales reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
        /// </summary>
        [IsoId("_0yxwZTj3EeSz-s1QOUJaOg")]
        [DisplayName("Sale Reconciliation Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SaleRcncltnId")]
        #endif
        [IsoXmlTag("SaleRcncltnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SaleReconciliationIdentification { get; init; } 
        #else
        public System.String? SaleReconciliationIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Unique reference of the sales as provided by the merchant.
        /// </summary>
        [IsoId("_0yxwZzj3EeSz-s1QOUJaOg")]
        [DisplayName("Sale Reference Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SaleRefNb")]
        #endif
        [IsoXmlTag("SaleRefNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? SaleReferenceNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SaleReferenceNumber { get; init; } 
        #else
        public System.String? SaleReferenceNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Reason for representment of a card transaction.
        /// </summary>
        [IsoId("_vfHeZTj3EeSz-s1QOUJaOg")]
        [DisplayName("Re Presentment Reason")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RePresntmntRsn")]
        #endif
        [IsoXmlTag("RePresntmntRsn")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ExternalRePresentmentReason1Code? RePresentmentReason { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ExternalRePresentmentReason1Code? RePresentmentReason { get; init; } 
        #else
        public ExternalRePresentmentReason1Code? RePresentmentReason { get; set; } 
        #endif
        
        /// <summary>
        /// Sequential number of the card transaction, as assigned by the POI (Point of Interaction). |Usage: The sequential number is increased incrementally for each transaction.
        /// </summary>
        [IsoId("_0yxwaTj3EeSz-s1QOUJaOg")]
        [DisplayName("Sequence Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="SeqNb")]
        #endif
        [IsoXmlTag("SeqNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? SequenceNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? SequenceNumber { get; init; } 
        #else
        public System.String? SequenceNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the transaction assigned by the POI (Point Of Interaction).
        /// </summary>
        [IsoId("_0yxwazj3EeSz-s1QOUJaOg")]
        [DisplayName("Transaction Identification")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="TxId")]
        #endif
        [IsoXmlTag("TxId")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public TransactionIdentifier1? TransactionIdentification { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public TransactionIdentifier1? TransactionIdentification { get; init; } 
        #else
        public TransactionIdentifier1? TransactionIdentification { get; set; } 
        #endif
        
        /// <summary>
        /// Product purchased with the transaction.
        /// </summary>
        [IsoId("_0yxwbTj3EeSz-s1QOUJaOg")]
        [DisplayName("Product")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Pdct")]
        #endif
        [IsoXmlTag("Pdct")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public Product2? Product { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public Product2? Product { get; init; } 
        #else
        public Product2? Product { get; set; } 
        #endif
        
        /// <summary>
        /// Date when the deposit was validated by the financial institution that collected the cash.
        /// </summary>
        [IsoId("_0yxwbzj3EeSz-s1QOUJaOg")]
        [DisplayName("Validation Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VldtnDt")]
        #endif
        [IsoXmlTag("VldtnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? ValidationDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? ValidationDate { get; init; } 
        #else
        public System.DateOnly? ValidationDate { get; set; } 
        #endif
        
        /// <summary>
        /// Sequential number of the validation of the cash deposit.
        /// Usage: The sequential number is increased incrementally for each transaction.
        /// </summary>
        [IsoId("_0yxwcTj3EeSz-s1QOUJaOg")]
        [DisplayName("Validation Sequence Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="VldtnSeqNb")]
        #endif
        [IsoXmlTag("VldtnSeqNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? ValidationSequenceNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? ValidationSequenceNumber { get; init; } 
        #else
        public System.String? ValidationSequenceNumber { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
