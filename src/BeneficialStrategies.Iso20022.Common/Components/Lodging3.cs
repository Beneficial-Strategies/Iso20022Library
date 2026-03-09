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
/// Lodging provides summary information about lodging accommodations and related expenses for the cardholder. 
/// </summary>
[IsoId("_SiW0AcWmEeuhguwJmlgagQ")]
[DisplayName("Lodging")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record Lodging3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Component provides summary information about lodging accommodations and related expenses for the cardholder. One occurrence of this component provides lodging accommodation reporting for a single lodging folio, such as a single stay at a lodging facility with one check-in and one check-out.
    /// </summary>
    [IsoId("_Sm2SccWmEeuhguwJmlgagQ")]
    [DisplayName("Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Summry")]
    #endif
    [IsoXmlTag("Summry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LodgingSummary2? Summary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LodgingSummary2? Summary { get; init; } 
    #else
    public LodgingSummary2? Summary { get; set; } 
    #endif
    
    /// <summary>
    /// Component provides detailed information about lodging accommodations and related expenses for the cardholder. Acquirers can submit multiple occurrences of this component for each lodging transaction, to provide details of one or more folios. 
    /// </summary>
    [IsoId("_Sm2Sc8WmEeuhguwJmlgagQ")]
    [DisplayName("Line Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineItm")]
    #endif
    [IsoXmlTag("LineItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public LodgingLineItem2? LineItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public LodgingLineItem2? LineItem { get; init; } 
    #else
    public LodgingLineItem2? LineItem { get; set; } 
    #endif
    
    
    #nullable disable
    
}
