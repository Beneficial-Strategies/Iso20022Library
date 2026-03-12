// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CardTransaction3Choice
{
    /// <summary>
    /// Card transaction details for the individual transaction, as recorded at the POI (point of interaction).
    /// </summary>
    [IsoId("_S-5Ek66BEeexrtTFgmVD3Q")]
    [DisplayName("Individual")]
    public partial record Individual : CardTransaction3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Data related to an integrated circuit card application.
        /// </summary>
        [IsoId("_vfHeYzj3EeSz-s1QOUJaOg")]
        [DisplayName("ICC Related Data")]
        [IsoXmlTag("ICCRltdData")]
        [IsoSimpleType(IsoSimpleType.Max1025Text)]
        [StringLength(maximumLength: 1025 ,MinimumLength = 1)]
        public IsoMax1025Text? ICCRelatedData { get; init; } 
        
        /// <summary>
        /// Context of the card payment transaction.
        /// </summary>
        [IsoId("_vfHeZDj3EeSz-s1QOUJaOg")]
        [DisplayName("Payment Context")]
        [IsoXmlTag("PmtCntxt")]
        public PaymentContext3? PaymentContext { get; init; } 
        
        /// <summary>
        /// Service in addition to the main service.
        /// </summary>
        [IsoId("_0yxwYTj3EeSz-s1QOUJaOg")]
        [DisplayName("Additional Service")]
        [IsoXmlTag("AddtlSvc")]
        public CardPaymentServiceType2Code? AdditionalService { get; init; } 
        
        /// <summary>
        /// Category code conform to ISO 18245, related to the type of services or goods the merchant provides for the transaction.
        /// This element is also known as the MerchantCategoryCode.
        /// </summary>
        [IsoId("_0yxwYzj3EeSz-s1QOUJaOg")]
        [DisplayName("Transaction Category")]
        [IsoXmlTag("TxCtgy")]
        public ExternalCardTransactionCategory1Code? TransactionCategory { get; init; } 
        
        /// <summary>
        /// Unique identification of the sales reconciliation period between the acceptor and the acquirer. This identification might be linked to the identification of the settlement for further verification by the merchant.
        /// </summary>
        [IsoId("_0yxwZTj3EeSz-s1QOUJaOg")]
        [DisplayName("Sale Reconciliation Identification")]
        [IsoXmlTag("SaleRcncltnId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? SaleReconciliationIdentification { get; init; } 
        
        /// <summary>
        /// Unique reference of the sales as provided by the merchant.
        /// </summary>
        [IsoId("_0yxwZzj3EeSz-s1QOUJaOg")]
        [DisplayName("Sale Reference Number")]
        [IsoXmlTag("SaleRefNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? SaleReferenceNumber { get; init; } 
        
        /// <summary>
        /// Reason for representment of a card transaction.
        /// </summary>
        [IsoId("_vfHeZTj3EeSz-s1QOUJaOg")]
        [DisplayName("Re Presentment Reason")]
        [IsoXmlTag("RePresntmntRsn")]
        public ExternalRePresentmentReason1Code? RePresentmentReason { get; init; } 
        
        /// <summary>
        /// Sequential number of the card transaction, as assigned by the POI (Point of Interaction). |Usage: The sequential number is increased incrementally for each transaction.
        /// </summary>
        [IsoId("_0yxwaTj3EeSz-s1QOUJaOg")]
        [DisplayName("Sequence Number")]
        [IsoXmlTag("SeqNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? SequenceNumber { get; init; } 
        
        /// <summary>
        /// Identification of the transaction assigned by the POI (Point Of Interaction).
        /// </summary>
        [IsoId("_0yxwazj3EeSz-s1QOUJaOg")]
        [DisplayName("Transaction Identification")]
        [IsoXmlTag("TxId")]
        public TransactionIdentifier1? TransactionIdentification { get; init; } 
        
        /// <summary>
        /// Product purchased with the transaction.
        /// </summary>
        [IsoId("_0yxwbTj3EeSz-s1QOUJaOg")]
        [DisplayName("Product")]
        [IsoXmlTag("Pdct")]
        public Product2? Product { get; init; } 
        
        /// <summary>
        /// Date when the deposit was validated by the financial institution that collected the cash.
        /// </summary>
        [IsoId("_0yxwbzj3EeSz-s1QOUJaOg")]
        [DisplayName("Validation Date")]
        [IsoXmlTag("VldtnDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ValidationDate { get; init; } 
        
        /// <summary>
        /// Sequential number of the validation of the cash deposit.
        /// Usage: The sequential number is increased incrementally for each transaction.
        /// </summary>
        [IsoId("_0yxwcTj3EeSz-s1QOUJaOg")]
        [DisplayName("Validation Sequence Number")]
        [IsoXmlTag("VldtnSeqNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? ValidationSequenceNumber { get; init; } 
        
        
        #nullable disable
        
    }
}
