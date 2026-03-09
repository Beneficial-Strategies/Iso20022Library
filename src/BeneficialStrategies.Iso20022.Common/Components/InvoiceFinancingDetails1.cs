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
/// Detailed information about single invoice/instalment financing result, such as result of request (financed or not financed), amount, percentage applied.
/// </summary>
[IsoId("_ThypxNp-Ed-ak6NoX_4Aeg_1200073540")]
[DisplayName("Invoice Financing Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record InvoiceFinancingDetails1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a InvoiceFinancingDetails1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public InvoiceFinancingDetails1( OriginalInvoiceInformation1 reqOriginalInvoiceInformation,FinancingResult1 reqInvoiceFinancingResult )
    {
        OriginalInvoiceInformation = reqOriginalInvoiceInformation;
        InvoiceFinancingResult = reqInvoiceFinancingResult;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// General information that unambiguously identifies the invoice contained in the original request.
    /// </summary>
    [IsoId("_Thypxdp-Ed-ak6NoX_4Aeg_1348559933")]
    [DisplayName("Original Invoice Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlInvcInf")]
    #endif
    [IsoXmlTag("OrgnlInvcInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required OriginalInvoiceInformation1 OriginalInvoiceInformation { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required OriginalInvoiceInformation1 OriginalInvoiceInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalInvoiceInformation1 OriginalInvoiceInformation { get; init; } 
    #else
    public OriginalInvoiceInformation1 OriginalInvoiceInformation { get; set; } 
    #endif
    
    /// <summary>
    /// Person or organization that represents the creditor for the invoice to be financed.
    /// </summary>
    [IsoId("_Thypxtp-Ed-ak6NoX_4Aeg_-989546543")]
    [DisplayName("Supplier")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Spplr")]
    #endif
    [IsoXmlTag("Spplr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PartyIdentification8? Supplier { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PartyIdentification8? Supplier { get; init; } 
    #else
    public PartyIdentification8? Supplier { get; set; } 
    #endif
    
    /// <summary>
    /// Information about result of invoice financing request.
    /// </summary>
    [IsoId("_Thypx9p-Ed-ak6NoX_4Aeg_1696461890")]
    [DisplayName("Invoice Financing Result")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcFincgRslt")]
    #endif
    [IsoXmlTag("InvcFincgRslt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancingResult1 InvoiceFinancingResult { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancingResult1 InvoiceFinancingResult { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingResult1 InvoiceFinancingResult { get; init; } 
    #else
    public FinancingResult1 InvoiceFinancingResult { get; set; } 
    #endif
    
    /// <summary>
    /// Includes details about a single instalment within an invoice, such as identification and amount.
    /// </summary>
    [IsoId("_ThypyNp-Ed-ak6NoX_4Aeg_2076029175")]
    [DisplayName("Instalment Financing Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstlmtFincgInf")]
    #endif
    [IsoXmlTag("InstlmtFincgInf")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InstalmentFinancingInformation1? InstalmentFinancingInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InstalmentFinancingInformation1? InstalmentFinancingInformation { get; init; } 
    #else
    public InstalmentFinancingInformation1? InstalmentFinancingInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
