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
[IsoId("_9VSAYU6sEeyGi9JAv6wq7Q")]
[DisplayName("Status Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusReport11
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusReport11 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusReport11( GenericIdentification176 reqPOIIdentification,GenericIdentification176 reqTerminalManagerIdentification,StatusReportDataSetRequest3 reqDataSet )
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
    [IsoId("_9bevAU6sEeyGi9JAv6wq7Q")]
    [DisplayName("POI Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIId")]
    #endif
    [IsoXmlTag("POIId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification176 POIIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification176 POIIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification176 POIIdentification { get; init; } 
    #else
    public GenericIdentification176 POIIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the requestor.
    /// </summary>
    [IsoId("_9bevA06sEeyGi9JAv6wq7Q")]
    [DisplayName("Initiating Trigger")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InitgTrggr")]
    #endif
    [IsoXmlTag("InitgTrggr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TriggerInformation2? InitiatingTrigger { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TriggerInformation2? InitiatingTrigger { get; init; } 
    #else
    public TriggerInformation2? InitiatingTrigger { get; set; } 
    #endif
    
    /// <summary>
    /// Identification of the terminal management system (TMS) to contact for the maintenance.
    /// </summary>
    [IsoId("_9bevBU6sEeyGi9JAv6wq7Q")]
    [DisplayName("Terminal Manager Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TermnlMgrId")]
    #endif
    [IsoXmlTag("TermnlMgrId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required GenericIdentification176 TerminalManagerIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public GenericIdentification176 TerminalManagerIdentification { get; init; } 
    #else
    public GenericIdentification176 TerminalManagerIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a status report of a point of interaction (POI).
    /// </summary>
    [IsoId("_9bevB06sEeyGi9JAv6wq7Q")]
    [DisplayName("Data Set")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSet")]
    #endif
    [IsoXmlTag("DataSet")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required StatusReportDataSetRequest3 DataSet { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required StatusReportDataSetRequest3 DataSet { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public StatusReportDataSetRequest3 DataSet { get; init; } 
    #else
    public StatusReportDataSetRequest3 DataSet { get; set; } 
    #endif
    
    
    #nullable disable
    
}
