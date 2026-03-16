// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Tracker Investigation Request Status3.
/// </summary>
[IsoId("_heHI0Z95Ee6ujbXJ3GcKgA")]
[DisplayName("Tracker Investigation Request Status3")]
public partial record TrackerInvestigationRequestStatus3
{
    #nullable enable

    /// <summary>
    /// Additional Information.
    /// </summary>
    [DisplayName("Additional Information")]
    [IsoXmlTag("AddtlInf")]
    public ValueList<IsoMax105Text> AdditionalInformation { get; init; } = [];

    /// <summary>
    /// Instructed Agent.
    /// </summary>
    [DisplayName("Instructed Agent")]
    [IsoXmlTag("InstdAgt")]
    public BranchAndFinancialInstitutionIdentification8? InstructedAgent { get; init; } 

    /// <summary>
    /// Investigation Identification.
    /// </summary>
    [DisplayName("Investigation Identification")]
    [IsoXmlTag("InvstgtnId")]
    public InvestigationIdentification1? InvestigationIdentification { get; init; } 

    /// <summary>
    /// Investigation Requestor.
    /// </summary>
    [DisplayName("Investigation Requestor")]
    [IsoXmlTag("InvstgtnRqstr")]
    public Party50Choice_? InvestigationRequestor { get; init; } 

    /// <summary>
    /// Investigation Responder.
    /// </summary>
    [DisplayName("Investigation Responder")]
    [IsoXmlTag("InvstgtnRspndr")]
    public Party50Choice_? InvestigationResponder { get; init; } 

    /// <summary>
    /// Status.
    /// </summary>
    [DisplayName("Status")]
    [IsoXmlTag("Sts")]
    public required InvestigationRequestStatus1Choice_ Status { get; init; } 

    /// <summary>
    /// Status Date.
    /// </summary>
    [DisplayName("Status Date")]
    [IsoXmlTag("StsDt")]
    public DateAndDateTime2Choice_? StatusDate { get; init; } 

    /// <summary>
    /// Status Reason.
    /// </summary>
    [DisplayName("Status Reason")]
    [IsoXmlTag("StsRsn")]
    public ValueList<InvestigationRequestStatusReason1Choice_> StatusReason { get; init; } = [];

    /// <summary>
    /// Tracked Message Identification.
    /// </summary>
    [DisplayName("Tracked Message Identification")]
    [IsoXmlTag("TrckdMsgId")]
    public OriginalBusinessInstruction4? TrackedMessageIdentification { get; init; } 

    /// <summary>
    /// Tracker Informed Party.
    /// </summary>
    [DisplayName("Tracker Informed Party")]
    [IsoXmlTag("TrckrInfrmdPty")]
    public TrackerPartyIdentification3? TrackerInformedParty { get; init; } 

    /// <summary>
    /// Tracker Informing Party.
    /// </summary>
    [DisplayName("Tracker Informing Party")]
    [IsoXmlTag("TrckrInfrmgPty")]
    public TrackerPartyIdentification3? TrackerInformingParty { get; init; } 

    
    #nullable disable
    
}
