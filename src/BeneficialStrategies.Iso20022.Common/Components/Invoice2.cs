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
/// Invoice data pertaining to the payment transaction.
/// </summary>
[IsoId("_VqOOwcWkEeuhguwJmlgagQ")]
[DisplayName("Invoice")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Invoice2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Invoice summary information.
    /// </summary>
    [IsoId("_VuiHAcWkEeuhguwJmlgagQ")]
    [DisplayName("Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Summry")]
    #endif
    [IsoXmlTag("Summry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvoiceSummary2? Summary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvoiceSummary2? Summary { get; init; } 
    #else
    public InvoiceSummary2? Summary { get; set; } 
    #endif
    
    /// <summary>
    /// Line item information.
    /// </summary>
    [IsoId("_VuiHA8WkEeuhguwJmlgagQ")]
    [DisplayName("Line Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineItm")]
    #endif
    [IsoXmlTag("LineItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvoiceLineItem2? LineItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvoiceLineItem2? LineItem { get; init; } 
    #else
    public InvoiceLineItem2? LineItem { get; set; } 
    #endif
    
    
    #nullable disable
    
}
