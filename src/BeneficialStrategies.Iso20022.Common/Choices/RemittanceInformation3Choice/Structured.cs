// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RemittanceInformation3Choice
{
    /// <summary>
    /// Information in structured form, that is supplied to enable the matching, ie, reconciliation, of a payment with the items that the payment is intended to settle, eg, commercial invoices in an account receivable system.
    /// </summary>
    [IsoId("_Rb-MwNp-Ed-ak6NoX_4Aeg_506340239")]
    [DisplayName("Structured")]
    public partial record Structured : RemittanceInformation3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the nature of the referred document/transaction, eg, invoice or credit note.
        /// </summary>
        [IsoId("_QFjMZ9p-Ed-ak6NoX_4Aeg_-1152515234")]
        [DisplayName("Referred Document Type")]
        [IsoXmlTag("RfrdDocTp")]
        public DocumentType1Code? ReferredDocumentType { get; init; } 
        
        /// <summary>
        /// Date associated with the referred document, eg, date of issue.
        /// </summary>
        [IsoId("_QFjMaNp-Ed-ak6NoX_4Aeg_-1151592780")]
        [DisplayName("Referred Document Related Date")]
        [IsoXmlTag("RfrdDocRltdDt")]
        [IsoSimpleType(IsoSimpleType.ISODate)]
        public IsoISODate? ReferredDocumentRelatedDate { get; init; } 
        
        /// <summary>
        /// Amount of money and currency of a document referred to in the remittance section. The amount is typically either the original amount due and payable, or the amount actually remitted for the referred document.
        /// </summary>
        [IsoId("_QFsWUNp-Ed-ak6NoX_4Aeg_-479270891")]
        [DisplayName("Referred Document Amount")]
        [IsoXmlTag("RfrdDocAmt")]
        public ReferredDocumentAmount1Choice_? ReferredDocumentAmount { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous identification of a document that distinguishes that document from another document referred to in the remittance information, usually assigned by the originator of the referred document/transaction.
        /// </summary>
        [IsoId("_QFsWUdp-Ed-ak6NoX_4Aeg_-1151593080")]
        [DisplayName("Document Reference Number")]
        [IsoXmlTag("DocRefNb")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? DocumentReferenceNumber { get; init; } 
        
        /// <summary>
        /// Unique and unambiguous reference assigned by the creditor to refer to the payment transaction.||Usage: if available, the initiating party should provide this reference in the structured remittance information, to enable reconciliation by the creditor upon receipt of the cash.||If the business context requires the use of a creditor reference or a payment remit identification, and only one identifier can be passed through the end-to-end chain, the creditor&apos;s reference or payment remittance identification should be quoted in the end-to-end transaction identification.
        /// </summary>
        [IsoId("_QFsWUtp-Ed-ak6NoX_4Aeg_-521744082")]
        [DisplayName("Creditor Reference")]
        [IsoXmlTag("CdtrRef")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35 ,MinimumLength = 1)]
        public IsoMax35Text? CreditorReference { get; init; } 
        
        /// <summary>
        /// Identification of the organization issuing the invoice when different than the creditor or final party.
        /// </summary>
        [IsoId("_QFsWU9p-Ed-ak6NoX_4Aeg_-1258212847")]
        [DisplayName("Invoicer")]
        [IsoXmlTag("Invcr")]
        public PartyIdentification1? Invoicer { get; init; } 
        
        /// <summary>
        /// Identification of the party to whom an invoice is issued, when different than the originator or debtor.
        /// </summary>
        [IsoId("_QFsWVNp-Ed-ak6NoX_4Aeg_-1543580746")]
        [DisplayName("Invoicee")]
        [IsoXmlTag("Invcee")]
        public PartyIdentification1? Invoicee { get; init; } 
        
        
        #nullable disable
        
    }
}
