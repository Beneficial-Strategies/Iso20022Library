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
/// Status of the acceptor system containing the identification of the POI (Point Of Interaction), its components and their installed versions.
/// </summary>
[IsoId("_79V60fGQEeibbsF9Yi4diw")]
[DisplayName("Status Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusReport8
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusReport8 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusReport8( GenericIdentification71 reqPOIIdentification,GenericIdentification71 reqTerminalManagerIdentification,TerminalManagementDataSet28 reqDataSet )
    {
        POIIdentification = reqPOIIdentification;
        TerminalManagerIdentification = reqTerminalManagerIdentification;
        DataSet = reqDataSet;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the point of interaction for terminal management.
    /// </summary>
    [IsoId("_8IRYcfGQEeibbsF9Yi4diw")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification71 POIIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification71 POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification71 POIIdentification { get; init; } 
    #else
    public GenericIdentification71 POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the requestor.
    /// </summary>
    [IsoId("_8IRYc_GQEeibbsF9Yi4diw")]
    [DisplayName("Initiating Trigger")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgTrggr")]
    #endif
    [IsoXmlTag("InitgTrggr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TriggerInformation1? InitiatingTrigger { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TriggerInformation1? InitiatingTrigger { get; init; } 
    #else
    public TriggerInformation1? InitiatingTrigger { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the terminal management system (TMS) to contact for the maintenance.
    /// </summary>
    [IsoId("_8IRYdfGQEeibbsF9Yi4diw")]
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
    /// Data related to a status report of a point of interaction (POI).
    /// </summary>
    [IsoId("_8IRYd_GQEeibbsF9Yi4diw")]
    [DisplayName("Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSet")]
    #endif
    [IsoXmlTag("DataSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TerminalManagementDataSet28 DataSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TerminalManagementDataSet28 DataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TerminalManagementDataSet28 DataSet { get; init; } 
    #else
    public TerminalManagementDataSet28 DataSet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
