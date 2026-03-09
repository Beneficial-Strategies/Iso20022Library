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
/// Content of the status report.
/// </summary>
[IsoId("_w2W44Si0Eeurkfo6MpvKDA")]
[DisplayName("Status Report Content")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record StatusReportContent10
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a StatusReportContent10 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public StatusReportContent10( System.DateTime reqPOIDateTime )
    {
        POIDateTime = reqPOIDateTime;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Capabilities of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    [IsoId("_xERZESi0Eeurkfo6MpvKDA")]
    [DisplayName("POI Capabilities")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POICpblties")]
    #endif
    [IsoXmlTag("POICpblties")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionCapabilities9? POICapabilities { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionCapabilities9? POICapabilities { get; init; } 
    #else
    public PointOfInteractionCapabilities9? POICapabilities { get; set; } 
    #endif
    
    /// <summary>
    /// Data related to a component of the POI (Point Of Interaction) performing the status report.
    /// </summary>
    [IsoId("_xERZEyi0Eeurkfo6MpvKDA")]
    [DisplayName("POI Component")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POICmpnt")]
    #endif
    [IsoXmlTag("POICmpnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PointOfInteractionComponent11? POIComponent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PointOfInteractionComponent11? POIComponent { get; init; } 
    #else
    public PointOfInteractionComponent11? POIComponent { get; set; } 
    #endif
    
    /// <summary>
    /// Identifier assigned to a set of POI terminals performing some categories of transactions.
    /// </summary>
    [IsoId("_fCj4YTANEeugIJ3Gvoevmg")]
    [DisplayName("POI Group Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIGrpId")]
    #endif
    [IsoXmlTag("POIGrpId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? POIGroupIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? POIGroupIdentification { get; init; } 
    #else
    public System.String? POIGroupIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Human attendance at the POI (Point Of Interaction) location during transactions.
    /// </summary>
    [IsoId("_xERZFSi0Eeurkfo6MpvKDA")]
    [DisplayName("Attendance Context")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AttndncCntxt")]
    #endif
    [IsoXmlTag("AttndncCntxt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AttendanceContext1Code? AttendanceContext { get; init; } 
    #else
    public AttendanceContext1Code? AttendanceContext { get; set; } 
    #endif
    
    /// <summary>
    /// System date time of the point of interaction (POI) sending the status report.
    /// </summary>
    [IsoId("_xERZFyi0Eeurkfo6MpvKDA")]
    [DisplayName("POI Date Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="POIDtTm")]
    #endif
    [IsoXmlTag("POIDtTm")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoISODateTime POIDateTime { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.DateTime POIDateTime { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime POIDateTime { get; init; } 
    #else
    public System.DateTime POIDateTime { get; set; } 
    #endif
    
    /// <summary>
    /// Request the terminal management system to answer with the identified data set.
    /// </summary>
    [IsoId("_xERZGSi0Eeurkfo6MpvKDA")]
    [DisplayName("Data Set Required")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DataSetReqrd")]
    #endif
    [IsoXmlTag("DataSetReqrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DataSetRequest2? DataSetRequired { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DataSetRequest2? DataSetRequired { get; init; } 
    #else
    public DataSetRequest2? DataSetRequired { get; set; } 
    #endif
    
    /// <summary>
    /// Result of an individual terminal management action by the point of interaction.
    /// </summary>
    [IsoId("_xERZGyi0Eeurkfo6MpvKDA")]
    [DisplayName("Event")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Evt")]
    #endif
    [IsoXmlTag("Evt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TMSEvent8? Event { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TMSEvent8? Event { get; init; } 
    #else
    public TMSEvent8? Event { get; set; } 
    #endif
    
    /// <summary>
    /// Error log of the point of interaction since the last status report.
    /// </summary>
    [IsoId("_xERZHSi0Eeurkfo6MpvKDA")]
    [DisplayName("Errors")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Errs")]
    #endif
    [IsoXmlTag("Errs")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax140Text? Errors { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? Errors { get; init; } 
    #else
    public System.String? Errors { get; set; } 
    #endif
    
    
    #nullable disable
    
}
