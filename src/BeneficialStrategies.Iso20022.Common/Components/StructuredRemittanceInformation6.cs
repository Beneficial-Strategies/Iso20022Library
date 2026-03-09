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
/// Structured information supplied to enable the matching, i.e. reconciliation, of a payment with the items that the payment is intended to settle, eg, commercial invoices in an accounts receivable system.
/// </summary>
[IsoId("_QFZbYtp-Ed-ak6NoX_4Aeg_-141764551")]
[DisplayName("Structured Remittance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StructuredRemittanceInformation6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Reference information to allow the identification of the underlying reference documents.
    /// </summary>
    [IsoId("_QFZbY9p-Ed-ak6NoX_4Aeg_758670115")]
    [DisplayName("Referred Document Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfrdDocInf")]
    #endif
    [IsoXmlTag("RfrdDocInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReferredDocumentInformation1? ReferredDocumentInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReferredDocumentInformation1? ReferredDocumentInformation { get; init; } 
    #else
    public ReferredDocumentInformation1? ReferredDocumentInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Date associated with the referred document, eg, date of issue.
    /// </summary>
    [IsoId("_QFZbZNp-Ed-ak6NoX_4Aeg_-141764239")]
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
    [IsoId("_QFZbZdp-Ed-ak6NoX_4Aeg_-141764204")]
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
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    [IsoId("_QFZbZtp-Ed-ak6NoX_4Aeg_1486861224")]
    [DisplayName("Creditor Reference Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrRefInf")]
    #endif
    [IsoXmlTag("CdtrRefInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditorReferenceInformation1? CreditorReferenceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditorReferenceInformation1? CreditorReferenceInformation { get; init; } 
    #else
    public CreditorReferenceInformation1? CreditorReferenceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the organization issuing the invoice when different than the creditor or final party.
    /// </summary>
    [IsoId("_QFZbZ9p-Ed-ak6NoX_4Aeg_-141763664")]
    [DisplayName("Invoicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invcr")]
    #endif
    [IsoXmlTag("Invcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? Invoicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? Invoicer { get; init; } 
    #else
    public PartyIdentification8? Invoicer { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party to whom an invoice is issued, when different than the originator or debtor.
    /// </summary>
    [IsoId("_QFZbaNp-Ed-ak6NoX_4Aeg_-141763290")]
    [DisplayName("Invoicee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invcee")]
    #endif
    [IsoXmlTag("Invcee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? Invoicee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? Invoicee { get; init; } 
    #else
    public PartyIdentification8? Invoicee { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [IsoId("_QFjMYNp-Ed-ak6NoX_4Aeg_-141764179")]
    [DisplayName("Additional Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRmtInf")]
    #endif
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? AdditionalRemittanceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalRemittanceInformation { get; init; } 
    #else
    public System.String? AdditionalRemittanceInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
