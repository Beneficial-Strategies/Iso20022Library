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
/// Provides detailed information on the transaction alert status notification from the tracker.
/// </summary>
[IsoId("_epS_xc78EemEIuVuDudp4g")]
[DisplayName("Tracker Alert Notification Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerAlertNotificationStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerAlertNotificationStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerAlertNotificationStatus1( TrackerAlertStatus1Choice_ reqAlertStatus )
    {
        AlertStatus = reqAlertStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Specifies the status of an alert, in a coded form.
    /// </summary>
    [IsoId("_epS_xs78EemEIuVuDudp4g")]
    [DisplayName("Alert Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AlrtSts")]
    #endif
    [IsoXmlTag("AlrtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required TrackerAlertStatus1Choice_ AlertStatus { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required TrackerAlertStatus1Choice_ AlertStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerAlertStatus1Choice_ AlertStatus { get; init; } 
    #else
    public TrackerAlertStatus1Choice_ AlertStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_epS_x878EemEIuVuDudp4g")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerAlertStatusReason1Choice_? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerAlertStatusReason1Choice_? StatusReason { get; init; } 
    #else
    public TrackerAlertStatusReason1Choice_? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [IsoId("_epS_yc78EemEIuVuDudp4g")]
    [DisplayName("Additional Information")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AddtlInf")]
    #endif
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax105Text? AdditionalInformation { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? AdditionalInformation { get; init; } 
    #else
    public System.String? AdditionalInformation { get; set; } 
    #endif
    
    
    #nullable disable
    
}
