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
[IsoId("_kIBx569UEeeJJK1oRb-jTw")]
[DisplayName("Structured Remittance Information")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StructuredRemittanceInformation14
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Set of elements used to identify the documents referred to in the remittance information.
    /// </summary>
    [IsoId("_kR4Rc69UEeeJJK1oRb-jTw")]
    [DisplayName("Referred Document Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RfrdDocInf")]
    #endif
    [IsoXmlTag("RfrdDocInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ReferredDocumentInformation3? ReferredDocumentInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReferredDocumentInformation3? ReferredDocumentInformation { get; init; } 
    #else
    public ReferredDocumentInformation3? ReferredDocumentInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Provides details on the amounts of the referred document.
    /// </summary>
    [IsoId("_kR4Rda9UEeeJJK1oRb-jTw")]
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
    [IsoId("_kR4Rd69UEeeJJK1oRb-jTw")]
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
    [IsoId("_kR4Rea9UEeeJJK1oRb-jTw")]
    [DisplayName("Invoicer")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invcr")]
    #endif
    [IsoXmlTag("Invcr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification125? Invoicer { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification125? Invoicer { get; init; } 
    #else
    public PartyIdentification125? Invoicer { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the party to whom an invoice is issued, when it is different from the debtor or ultimate debtor.
    /// </summary>
    [IsoId("_kR4Re69UEeeJJK1oRb-jTw")]
    [DisplayName("Invoicee")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Invcee")]
    #endif
    [IsoXmlTag("Invcee")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification125? Invoicee { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification125? Invoicee { get; init; } 
    #else
    public PartyIdentification125? Invoicee { get; set; } 
    #endif
    
    /// <summary>
    /// Additional information, in free text form, to complement the structured remittance information.
    /// </summary>
    [IsoId("_kR4Rfa9UEeeJJK1oRb-jTw")]
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
