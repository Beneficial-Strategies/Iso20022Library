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
namespace BeneficialStrategies.Iso20022.Choices.RemittanceInformation3Choice
{
    /// <summary>
    /// Information in structured form, that is supplied to enable the matching, ie, reconciliation, of a payment with the items that the payment is intended to settle, eg, commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_Rb-MwNp-Ed-ak6NoX_4Aeg_506340239")]
    [DisplayName("Structured")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public partial record Structured : RemittanceInformation3Choice_
    #else
    public partial class Structured : RemittanceInformation3Choice_
    #endif
    {
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        // No constructor needed for NET8 and above.
        #else
        // No constructor needed for < NET8 because this type has no required members.
        #endif
        #nullable enable
        
        /// <summary>
        /// Specifies the nature of the referred document/transaction, eg, invoice or credit note.
        /// </summary>
        [IsoId("_QFjMZ9p-Ed-ak6NoX_4Aeg_-1152515234")]
        [DisplayName("Referred Document Type")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RfrdDocTp")]
        #endif
        [IsoXmlTag("RfrdDocTp")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public DocumentType1Code? ReferredDocumentType { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public DocumentType1Code? ReferredDocumentType { get; init; } 
        #else
        public DocumentType1Code? ReferredDocumentType { get; set; } 
        #endif
        
        /// <summary>
        /// Date associated with the referred document, eg, date of issue.
        /// </summary>
        [IsoId("_QFjMaNp-Ed-ak6NoX_4Aeg_-1151592780")]
        [DisplayName("Referred Document Related Date")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RfrdDocRltdDt")]
        #endif
        [IsoXmlTag("RfrdDocRltdDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoISODate? ReferredDocumentRelatedDate { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.DateOnly? ReferredDocumentRelatedDate { get; init; } 
        #else
        public System.DateOnly? ReferredDocumentRelatedDate { get; set; } 
        #endif
        
        /// <summary>
        /// Amount of money and currency of a document referred to in the remittance section. The amount is typically either the original amount due and payable, or the amount actually remitted for the referred document.
        /// </summary>
        [IsoId("_QFsWUNp-Ed-ak6NoX_4Aeg_-479270891")]
        [DisplayName("Referred Document Amount")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="RfrdDocAmt")]
        #endif
        [IsoXmlTag("RfrdDocAmt")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public ReferredDocumentAmount1Choice_? ReferredDocumentAmount { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public ReferredDocumentAmount1Choice_? ReferredDocumentAmount { get; init; } 
        #else
        public ReferredDocumentAmount1Choice_? ReferredDocumentAmount { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous identification of a document that distinguishes that document from another document referred to in the remittance information, usually assigned by the originator of the referred document/transaction.
        /// </summary>
        [IsoId("_QFsWUdp-Ed-ak6NoX_4Aeg_-1151593080")]
        [DisplayName("Document Reference Number")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="DocRefNb")]
        #endif
        [IsoXmlTag("DocRefNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? DocumentReferenceNumber { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? DocumentReferenceNumber { get; init; } 
        #else
        public System.String? DocumentReferenceNumber { get; set; } 
        #endif
        
        /// <summary>
        /// Unique and unambiguous reference assigned by the creditor to refer to the payment transaction.||Usage: if available, the initiating party should provide this reference in the structured remittance information, to enable reconciliation by the creditor upon receipt of the cash.||If the business context requires the use of a creditor reference or a payment remit identification, and only one identifier can be passed through the end-to-end chain, the creditor&apos;s reference or payment remittance identification should be quoted in the end-to-end transaction identification.
        /// </summary>
        [IsoId("_QFsWUtp-Ed-ak6NoX_4Aeg_-521744082")]
        [DisplayName("Creditor Reference")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="CdtrRef")]
        #endif
        [IsoXmlTag("CdtrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public IsoMax35Text? CreditorReference { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public System.String? CreditorReference { get; init; } 
        #else
        public System.String? CreditorReference { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the organization issuing the invoice when different than the creditor or final party.
        /// </summary>
        [IsoId("_QFsWU9p-Ed-ak6NoX_4Aeg_-1258212847")]
        [DisplayName("Invoicer")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Invcr")]
        #endif
        [IsoXmlTag("Invcr")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification1? Invoicer { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification1? Invoicer { get; init; } 
        #else
        public PartyIdentification1? Invoicer { get; set; } 
        #endif
        
        /// <summary>
        /// Identification of the party to whom an invoice is issued, when different than the originator or debtor.
        /// </summary>
        [IsoId("_QFsWVNp-Ed-ak6NoX_4Aeg_-1543580746")]
        [DisplayName("Invoicee")]
        #if DECLARE_DATACONTRACT
        [DataMember(Name="Invcee")]
        #endif
        [IsoXmlTag("Invcee")]
        #if NET8_0_OR_GREATER // C# 12 Global type alias
        public PartyIdentification1? Invoicee { get; init; } 
        #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
        public PartyIdentification1? Invoicee { get; init; } 
        #else
        public PartyIdentification1? Invoicee { get; set; } 
        #endif
        
        
        #nullable disable
        
    }
}
