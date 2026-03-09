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
/// Information supplied to enable the matching/reconciliation of an entry with the items that the payment is intended to settle, such as commercial invoices in an accounts&apos; receivable system, in a structured form.
/// </summary>
[IsoId("_VOKmgaJmEeKmspP9k_hIRQ")]
[DisplayName("Structured Remittance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StructuredRemittanceInformation10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements used to provide the content of the referred document.
    /// </summary>
    [IsoId("_VZMKxaJmEeKmspP9k_hIRQ")]
    [DisplayName("Referred Document Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfrdDocInf")]
    #endif
    [IsoXmlTag("RfrdDocInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReferredDocumentInformation4? ReferredDocumentInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReferredDocumentInformation4? ReferredDocumentInformation { get; init; } 
    #else
    public ReferredDocumentInformation4? ReferredDocumentInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the amounts of the referred document.
    /// </summary>
    [IsoId("_VZMKyaJmEeKmspP9k_hIRQ")]
    [DisplayName("Referred Document Amount")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfrdDocAmt")]
    #endif
    [IsoXmlTag("RfrdDocAmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public RemittanceAmount2? ReferredDocumentAmount { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public RemittanceAmount2? ReferredDocumentAmount { get; init; } 
    #else
    public RemittanceAmount2? ReferredDocumentAmount { get; set; } 
    #endif
    
    /// <summary>
    /// Reference information provided by the creditor to allow the identification of the underlying documents.
    /// </summary>
    [IsoId("_VZMKzaJmEeKmspP9k_hIRQ")]
    [DisplayName("Creditor Reference Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CdtrRefInf")]
    #endif
    [IsoXmlTag("CdtrRefInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; init; } 
    #else
    public CreditorReferenceInformation2? CreditorReferenceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the organisation issuing the invoice, when it is different from the creditor or ultimate creditor.
    /// </summary>
    [IsoId("_VZMK0aJmEeKmspP9k_hIRQ")]
    [DisplayName("Invoicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invcr")]
    #endif
    [IsoXmlTag("Invcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? Invoicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? Invoicer { get; init; } 
    #else
    public PartyIdentification43? Invoicer { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    [IsoId("_VZMK1aJmEeKmspP9k_hIRQ")]
    [DisplayName("Invoicee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invcee")]
    #endif
    [IsoXmlTag("Invcee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification43? Invoicee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification43? Invoicee { get; init; } 
    #else
    public PartyIdentification43? Invoicee { get; set; } 
    #endif
    
    /// <summary>
    /// Provides remittance information about a payment made for tax-related purposes.
    /// </summary>
    [IsoId("_Oy4L0KJrEeKmspP9k_hIRQ")]
    [DisplayName("Tax Remittance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TaxRmt")]
    #endif
    [IsoXmlTag("TaxRmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TaxInformation4? TaxRemittance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TaxInformation4? TaxRemittance { get; init; } 
    #else
    public TaxInformation4? TaxRemittance { get; set; } 
    #endif
    
    /// <summary>
    /// Provides remittance information about a payment for garnishment-related purposes.
    /// </summary>
    [IsoId("_sK4DwKJvEeK9W_i6uXeloA")]
    [DisplayName("Garnishment Remittance")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="GrnshmtRmt")]
    #endif
    [IsoXmlTag("GrnshmtRmt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Garnishment1? GarnishmentRemittance { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Garnishment1? GarnishmentRemittance { get; init; } 
    #else
    public Garnishment1? GarnishmentRemittance { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [IsoId("_VZMK2aJmEeKmspP9k_hIRQ")]
    [DisplayName("Additional Remittance Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlRmtInf")]
    #endif
    [IsoXmlTag("AddtlRmtInf")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [MinLength(0)]
    [MaxLength(3)]
    public SimpleValueList<System.String> AdditionalRemittanceInformation { get; init; } = new SimpleValueList<System.String>(){};
    
    
    #nullable disable
    
}
