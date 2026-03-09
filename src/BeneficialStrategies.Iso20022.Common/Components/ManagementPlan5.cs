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
/// Sequence of terminal management actions to be performed by a point of interaction (POI).
/// </summary>
[IsoId("_N1xKQY30EeWYyJ6P6VfQMg")]
[DisplayName("Management Plan")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ManagementPlan5
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ManagementPlan5 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ManagementPlan5( GenericIdentification71 reqTerminalManagerIdentification,TerminalManagementDataSet18 reqDataSet )
    {
        TerminalManagerIdentification = reqTerminalManagerIdentification;
        DataSet = reqDataSet;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction (POI) for terminal management.
    /// </summary>
    [IsoId("_OB13YY30EeWYyJ6P6VfQMg")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public GenericIdentification71? POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification71? POIIdentification { get; init; } 
    #else
    public GenericIdentification71? POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the terminal management system (TMS) sending the management plan.
    /// </summary>
    [IsoId("_OB13Y430EeWYyJ6P6VfQMg")]
    [DisplayName("Terminal Manager Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlMgrId")]
    #endif
    [IsoXmlTag("TermnlMgrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification71 TerminalManagerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification71 TerminalManagerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification71 TerminalManagerIdentification { get; init; } 
    #else
    public GenericIdentification71 TerminalManagerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Data set related to the sequence of actions to be performed by a point of interaction (POI).
    /// </summary>
    [IsoId("_OB13ZY30EeWYyJ6P6VfQMg")]
    [DisplayName("Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSet")]
    #endif
    [IsoXmlTag("DataSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementDataSet18 DataSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementDataSet18 DataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementDataSet18 DataSet { get; init; } 
    #else
    public TerminalManagementDataSet18 DataSet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
