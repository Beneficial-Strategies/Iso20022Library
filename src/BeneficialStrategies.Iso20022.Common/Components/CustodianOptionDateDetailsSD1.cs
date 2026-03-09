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
/// Corporate action option information for the custodian record.
/// </summary>
[IsoId("_1TqvATL3EeKU9IrkkToqcw_1383220652")]
[DisplayName("Custodian Option Date Details SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CustodianOptionDateDetailsSD1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CustodianOptionDateDetailsSD1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CustodianOptionDateDetailsSD1( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1TqvAjL3EeKU9IrkkToqcw_-1902659123")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Custodian deadline date for the option instructions. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1TqvAzL3EeKU9IrkkToqcw_-26617381")]
    [DisplayName("Agent Deadline Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtDdlnDt")]
    #endif
    [IsoXmlTag("AgtDdlnDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? AgentDeadlineDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? AgentDeadlineDate { get; init; } 
    #else
    public System.DateOnly? AgentDeadlineDate { get; set; } 
    #endif
    
    /// <summary>
    /// Custodian deadline time for the option instructions. Applicable to custodian service only.
    /// </summary>
    [IsoId("_1TqvBDL3EeKU9IrkkToqcw_-744742048")]
    [DisplayName("Agent Deadline Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AgtDdlnTm")]
    #endif
    [IsoXmlTag("AgtDdlnTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? AgentDeadlineTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? AgentDeadlineTime { get; init; } 
    #else
    public System.TimeOnly? AgentDeadlineTime { get; set; } 
    #endif
    
    
    #nullable disable
    
}
