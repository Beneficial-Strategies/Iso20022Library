// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the transaction alert status notification from the tracker.
/// </summary>
[IsoId("_epS_xc78EemEIuVuDudp4g")]
[DisplayName("Tracker Alert Notification Status")]
public partial record TrackerAlertNotificationStatus1
{
    #nullable enable
    
    /// <summary>
    /// Specifies the status of an alert, in a coded form.
    /// </summary>
    [IsoId("_epS_xs78EemEIuVuDudp4g")]
    [DisplayName("Alert Status")]
    [IsoXmlTag("AlrtSts")]
    public required TrackerAlertStatus1Choice_ AlertStatus { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_epS_x878EemEIuVuDudp4g")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public TrackerAlertStatusReason1Choice_? StatusReason { get; init; } 
    
    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [IsoId("_epS_yc78EemEIuVuDudp4g")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    
    #nullable disable
    
}
