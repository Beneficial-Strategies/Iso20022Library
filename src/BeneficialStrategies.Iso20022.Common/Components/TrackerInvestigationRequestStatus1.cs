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
/// Provides detailed information on the investigation request status from the tracker.
/// </summary>
[IsoId("_TPTgYWHNEe2dtcJPyL3-cw")]
[DisplayName("Tracker Investigation Request Status")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record TrackerInvestigationRequestStatus1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a TrackerInvestigationRequestStatus1 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public TrackerInvestigationRequestStatus1( InvestigationRequestStatus1Choice_ reqStatus )
    {
        Status = reqStatus;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Status of request.
    /// </summary>
    [IsoId("_TYAJY2HNEe2dtcJPyL3-cw")]
    [DisplayName("Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sts")]
    #endif
    [IsoXmlTag("Sts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required InvestigationRequestStatus1Choice_ Status { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required InvestigationRequestStatus1Choice_ Status { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestigationRequestStatus1Choice_ Status { get; init; } 
    #else
    public InvestigationRequestStatus1Choice_ Status { get; set; } 
    #endif
    
    /// <summary>
    /// Provides detailed information on the status reason.
    /// </summary>
    [IsoId("_TYAJZWHNEe2dtcJPyL3-cw")]
    [DisplayName("Status Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsRsn")]
    #endif
    [IsoXmlTag("StsRsn")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public InvestigationRequestStatusReason1Choice_? StatusReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public InvestigationRequestStatusReason1Choice_? StatusReason { get; init; } 
    #else
    public InvestigationRequestStatusReason1Choice_? StatusReason { get; set; } 
    #endif
    
    /// <summary>
    /// Date for the status.
    /// </summary>
    [IsoId("_w5eQ0HbiEe2GR4CRzIB77g")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateAndDateTime2Choice_? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateAndDateTime2Choice_? Date { get; init; } 
    #else
    public DateAndDateTime2Choice_? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Further details on the status reason.||Usage: Additional information can be used for several purposes such as the reporting of repaired information.
    /// </summary>
    [IsoId("_TYAJZ2HNEe2dtcJPyL3-cw")]
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
    
    /// <summary>
    /// Party that provides information on the status and related details of the request.
    /// </summary>
    [IsoId("_Jms8gXfIEe2A6pitLvwC_g")]
    [DisplayName("Tracker Informing Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckrInfrmgPty")]
    #endif
    [IsoXmlTag("TrckrInfrmgPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerPartyIdentification2? TrackerInformingParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerPartyIdentification2? TrackerInformingParty { get; init; } 
    #else
    public TrackerPartyIdentification2? TrackerInformingParty { get; set; } 
    #endif
    
    /// <summary>
    /// Party that is updated on the status and related details of the request.
    /// </summary>
    [IsoId("_IL9c0XfIEe2A6pitLvwC_g")]
    [DisplayName("Tracker Informed Party")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckrInfrmdPty")]
    #endif
    [IsoXmlTag("TrckrInfrmdPty")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TrackerPartyIdentification2? TrackerInformedParty { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TrackerPartyIdentification2? TrackerInformedParty { get; init; } 
    #else
    public TrackerPartyIdentification2? TrackerInformedParty { get; set; } 
    #endif
    
    /// <summary>
    /// Provides information on the original request message.
    /// </summary>
    [IsoId("_K9X0gXfIEe2A6pitLvwC_g")]
    [DisplayName("Tracked Message Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TrckdMsgId")]
    #endif
    [IsoXmlTag("TrckdMsgId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public OriginalBusinessInstruction4? TrackedMessageIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public OriginalBusinessInstruction4? TrackedMessageIdentification { get; init; } 
    #else
    public OriginalBusinessInstruction4? TrackedMessageIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Includes the entity to which the entity reporting the status has forwarded the case.
    /// </summary>
    [IsoId("_U5M7YmQHEe297MhDQvVHLQ")]
    [DisplayName("Instructed Agent")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InstdAgt")]
    #endif
    [IsoXmlTag("InstdAgt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; init; } 
    #else
    public BranchAndFinancialInstitutionIdentification6? InstructedAgent { get; set; } 
    #endif
    
    /// <summary>
    /// Identifies the entity to which the tracking facility has assigned the request.
    /// </summary>
    [IsoId("__6p7kXbjEe2GR4CRzIB77g")]
    [DisplayName("Investigation Responder")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="InvstgtnRspndr")]
    #endif
    [IsoXmlTag("InvstgtnRspndr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Party40Choice_? InvestigationResponder { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Party40Choice_? InvestigationResponder { get; init; } 
    #else
    public Party40Choice_? InvestigationResponder { get; set; } 
    #endif
    
    
    #nullable disable
    
}
