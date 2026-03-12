// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on an alert notification issued by the tracker.
/// </summary>
[IsoId("_k0GOM_Y0Eemf4dJxCjghNw")]
[DisplayName("Tracker Alert Notification Status")]
public partial record TrackerAlertNotificationStatus2
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of an alert, in a coded form.
    /// </summary>
    [IsoId("_k0GON_Y0Eemf4dJxCjghNw")]
    [DisplayName("Alert Status")]
    [IsoXmlTag("AlrtSts")]
    public required TrackerAlertStatus1 AlertStatus { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_k0GOOfY0Eemf4dJxCjghNw")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public required TrackerAlertStatusReason1 StatusReason { get; init; } 
    
    
    #nullable disable
    
}
