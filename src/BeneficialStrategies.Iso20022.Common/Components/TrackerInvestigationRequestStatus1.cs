// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Provides detailed information on the investigation request status from the tracker.
/// </summary>
[IsoId("_TPTgYWHNEe2dtcJPyL3-cw")]
[DisplayName("Tracker Investigation Request Status")]
public partial record TrackerInvestigationRequestStatus1
{
    #nullable enable
    
    /// <summary>
    /// Status of request.
    /// </summary>
    [IsoId("_TYAJY2HNEe2dtcJPyL3-cw")]
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required InvestigationRequestStatus1Choice_ Status { get; init; } 
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_TYAJZWHNEe2dtcJPyL3-cw")]
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public InvestigationRequestStatusReason1Choice_? StatusReason { get; init; } 
    
    /// <summary>
    /// Date for the status.
    /// </summary>
    [IsoId("_w5eQ0HbiEe2GR4CRzIB77g")]
    [DisplayName("Date")]
    [IsoXmlTag("Dt")]
    public DateAndDateTime2Choice_? Date { get; init; } 
    
    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [IsoId("_TYAJZ2HNEe2dtcJPyL3-cw")]
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    [IsoSimpleType(IsoSimpleType.Max105Text)]
    [StringLength(maximumLength: 105 ,MinimumLength = 1)]
    public IsoMax105Text? AdditionalInformation { get; init; } 
    
    /// <summary>
    /// Party that provides information on the status and related details of the request.
    /// </summary>
    [IsoId("_Jms8gXfIEe2A6pitLvwC_g")]
    [DisplayName("Tracker Informing Party")]
    [IsoXmlTag("TrckrInfrmgPty")]
    public TrackerPartyIdentification2? TrackerInformingParty { get; init; } 
    
    /// <summary>
    /// Party that is updated on the status and related details of the request.
    /// </summary>
    [IsoId("_IL9c0XfIEe2A6pitLvwC_g")]
    [DisplayName("Tracker Informed Party")]
    [IsoXmlTag("TrckrInfrmdPty")]
    public TrackerPartyIdentification2? TrackerInformedParty { get; init; } 
    
    /// <summary>
    /// Provides information on the original request message.
    /// </summary>
    [IsoId("_K9X0gXfIEe2A6pitLvwC_g")]
    [DisplayName("Tracked Message Identification")]
    [IsoXmlTag("TrckdMsgId")]
    public OriginalBusinessInstruction4? TrackedMessageIdentification { get; init; } 
    
    /// <summary>
    /// Includes the entity to which the entity reporting the status has forwarded the case.
    /// </summary>
    [IsoId("_U5M7YmQHEe297MhDQvVHLQ")]
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; } 
    
    /// <summary>
    /// Identifies the entity to which the tracking facility has assigned the request.
    /// </summary>
    [IsoId("__6p7kXbjEe2GR4CRzIB77g")]
    [DisplayName("Investigation Responder")]
    [IsoXmlTag("InvstgtnRspndr")]
    public Party40Choice_? InvestigationResponder { get; init; } 
    
    
    #nullable disable
    
}
