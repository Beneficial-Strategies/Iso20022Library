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
/// Financing information and status.
/// </summary>
[IsoId("_RYGZYtp-Ed-ak6NoX_4Aeg_645590457")]
[DisplayName("Financing Information And Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FinancingInformationAndStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a FinancingInformationAndStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public FinancingInformationAndStatus1( FinancingAllowedSummary1 reqFinancingAllowedSummary )
    {
        FinancingAllowedSummary = reqFinancingAllowedSummary;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies summary information about invoices/instalments financed, such as total amount financed, number of single requests accepted.
    /// </summary>
    [IsoId("_RYGZY9p-Ed-ak6NoX_4Aeg_-1388553810")]
    [DisplayName("Financing Allowed Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="FincgAllwdSummry")]
    #endif
    [IsoXmlTag("FincgAllwdSummry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required FinancingAllowedSummary1 FinancingAllowedSummary { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required FinancingAllowedSummary1 FinancingAllowedSummary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FinancingAllowedSummary1 FinancingAllowedSummary { get; init; } 
    #else
    public FinancingAllowedSummary1 FinancingAllowedSummary { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies detailed information about single invoice/instalment financing result, such as result of request (financed or not financed), amount, percentage applied.
    /// </summary>
    [IsoId("_RYGZZNp-Ed-ak6NoX_4Aeg_1262872441")]
    [DisplayName("Invoice Financing Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvcFincgDtls")]
    #endif
    [IsoXmlTag("InvcFincgDtls")]
    public ValueList<InvoiceFinancingDetails1> InvoiceFinancingDetails { get; init; } = new ValueList<InvoiceFinancingDetails1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _RYGZZNp-Ed-ak6NoX_4Aeg_1262872441
    
    
    #nullable disable
    
}
