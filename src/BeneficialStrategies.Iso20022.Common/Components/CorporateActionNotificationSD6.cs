// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides additional information regarding notification general information details.
/// </summary>
[IsoId("_1kgnZjL3EeKU9IrkkToqcw_1609699363")]
[DisplayName("Corporate Action Notification SD")]
public partial record CorporateActionNotificationSD6
{
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1k9TUDL3EeKU9IrkkToqcw_612627010")]
    [DisplayName("Place And Name")]
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    public required IsoMax350Text PlaceAndName { get; init; } 
    
    /// <summary>
    /// Workflow status of the event.
    /// </summary>
    [IsoId("_1lGdQDL3EeKU9IrkkToqcw_1484761520")]
    [DisplayName("Event Status")]
    [IsoXmlTag("EvtSts")]
    public EventWorkflowStatus1Code? EventStatus { get; init; } 
    
    /// <summary>
    /// Date by which the announcement is set to approve event status.
    /// </summary>
    [IsoId("_1lGdQTL3EeKU9IrkkToqcw_-395544120")]
    [DisplayName("Approved Date")]
    [IsoXmlTag("ApprvdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ApprovedDate { get; init; } 
    
    /// <summary>
    /// Date used to match records from multiple vendors to the same event. It is typically the first key date on the event.
    /// </summary>
    [IsoId("_1lGdQjL3EeKU9IrkkToqcw_-1506455539")]
    [DisplayName("Match Date")]
    [IsoXmlTag("MtchDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? MatchDate { get; init; } 
    
    /// <summary>
    /// Date until which the event will remain in an active status on DTCC (The Depository Trust and Clearing Corporation) system.
    /// </summary>
    [IsoId("_1lGdQzL3EeKU9IrkkToqcw_908206117")]
    [DisplayName("Active Until Date")]
    [IsoXmlTag("ActvUntilDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? ActiveUntilDate { get; init; } 
    
    /// <summary>
    /// Start date and end date of the service level agreement.
    /// </summary>
    [IsoId("_1lGdRDL3EeKU9IrkkToqcw_624171464")]
    [DisplayName("Service Level Agreement Period")]
    [IsoXmlTag("SvcLvlAgrmtPrd")]
    public Period3? ServiceLevelAgreementPeriod { get; init; } 
    
    /// <summary>
    /// Specifies a reason why a corporate action will not be supported by the validation service. This is usually due to the event type or the product (security) type. The list of values will be provided externally to the schema.
    /// </summary>
    [IsoId("_1lQOQDL3EeKU9IrkkToqcw_-1256134176")]
    [DisplayName("Validation Not Supported Reason")]
    [IsoXmlTag("VldtnNotSpprtdRsn")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    public IsoMax4AlphaNumericText? ValidationNotSupportedReason { get; init; } 
    
    
    #nullable disable
    
}
