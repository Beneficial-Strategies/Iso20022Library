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
/// Provides detailed information on an alert notification issued by the tracker.
/// </summary>
[IsoId("_k0GOM_Y0Eemf4dJxCjghNw")]
[DisplayName("Tracker Alert Notification Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerAlertNotificationStatus2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerAlertNotificationStatus2 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerAlertNotificationStatus2( TrackerAlertStatus1 reqAlertStatus,TrackerAlertStatusReason1 reqStatusReason )
    {
        AlertStatus = reqAlertStatus;
        StatusReason = reqStatusReason;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status of an alert, in a coded form.
    /// </summary>
    [IsoId("_k0GON_Y0Eemf4dJxCjghNw")]
    [DisplayName("Alert Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AlrtSts")]
    #endif
    [IsoXmlTag("AlrtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerAlertStatus1 AlertStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TrackerAlertStatus1 AlertStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerAlertStatus1 AlertStatus { get; init; } 
    #else
    public TrackerAlertStatus1 AlertStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_k0GOOfY0Eemf4dJxCjghNw")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerAlertStatusReason1 StatusReason { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TrackerAlertStatusReason1 StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerAlertStatusReason1 StatusReason { get; init; } 
    #else
    public TrackerAlertStatusReason1 StatusReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
