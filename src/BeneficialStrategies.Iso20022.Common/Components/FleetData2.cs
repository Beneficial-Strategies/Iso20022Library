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
/// Fleet data pertaining to the payment transaction.
/// </summary>
[IsoId("_zYIag_jNEeiM7KpzmLtmTQ")]
[DisplayName("Fleet Data")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record FleetData2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Invoice Summary information.
    /// </summary>
    [IsoId("_zYIahfjNEeiM7KpzmLtmTQ")]
    [DisplayName("Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Summry")]
    #endif
    [IsoXmlTag("Summry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FleetSummary1? Summary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FleetSummary1? Summary { get; init; } 
    #else
    public FleetSummary1? Summary { get; set; } 
    #endif
    
    /// <summary>
    /// Fleet Line Item component is designed to carry detail level fleet data and to enable issuers to supply more transaction information to their consumer and corporate clients pertaining to fleet transactions. 
    /// </summary>
    [IsoId("_zYIahPjNEeiM7KpzmLtmTQ")]
    [DisplayName("Line Item")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="LineItm")]
    #endif
    [IsoXmlTag("LineItm")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public FleetLineItem1? LineItem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public FleetLineItem1? LineItem { get; init; } 
    #else
    public FleetLineItem1? LineItem { get; set; } 
    #endif
    
    
    #nullable disable
    
}
