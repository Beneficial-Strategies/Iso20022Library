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
/// Provides additional information regarding notification general information details.
/// </summary>
[IsoId("_1kgnZjL3EeKU9IrkkToqcw_1609699363")]
[DisplayName("Corporate Action Notification SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNotificationSD6
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionNotificationSD6 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionNotificationSD6( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1k9TUDL3EeKU9IrkkToqcw_612627010")]
    [DisplayName("Place And Name")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="PlcAndNm")]
    #endif
    [IsoXmlTag("PlcAndNm")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required IsoMax350Text PlaceAndName { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required System.String PlaceAndName { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String PlaceAndName { get; init; } 
    #else
    public System.String PlaceAndName { get; set; } 
    #endif
    
    /// <summary>
    /// Workflow status of the event.
    /// </summary>
    [IsoId("_1lGdQDL3EeKU9IrkkToqcw_1484761520")]
    [DisplayName("Event Status")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtSts")]
    #endif
    [IsoXmlTag("EvtSts")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventWorkflowStatus1Code? EventStatus { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventWorkflowStatus1Code? EventStatus { get; init; } 
    #else
    public EventWorkflowStatus1Code? EventStatus { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the announcement is set to approve event status.
    /// </summary>
    [IsoId("_1lGdQTL3EeKU9IrkkToqcw_-395544120")]
    [DisplayName("Approved Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ApprvdDt")]
    #endif
    [IsoXmlTag("ApprvdDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ApprovedDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ApprovedDate { get; init; } 
    #else
    public System.DateOnly? ApprovedDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date used to match records from multiple vendors to the same event. It is typically the first key date on the event.
    /// </summary>
    [IsoId("_1lGdQjL3EeKU9IrkkToqcw_-1506455539")]
    [DisplayName("Match Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="MtchDt")]
    #endif
    [IsoXmlTag("MtchDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? MatchDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? MatchDate { get; init; } 
    #else
    public System.DateOnly? MatchDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date until which the event will remain in an active status on DTCC (The Depository Trust and Clearing Corporation) system.
    /// </summary>
    [IsoId("_1lGdQzL3EeKU9IrkkToqcw_908206117")]
    [DisplayName("Active Until Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="ActvUntilDt")]
    #endif
    [IsoXmlTag("ActvUntilDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? ActiveUntilDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? ActiveUntilDate { get; init; } 
    #else
    public System.DateOnly? ActiveUntilDate { get; set; } 
    #endif
    
    /// <summary>
    /// Start date and end date of the service level agreement.
    /// </summary>
    [IsoId("_1lGdRDL3EeKU9IrkkToqcw_624171464")]
    [DisplayName("Service Level Agreement Period")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SvcLvlAgrmtPrd")]
    #endif
    [IsoXmlTag("SvcLvlAgrmtPrd")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Period3? ServiceLevelAgreementPeriod { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Period3? ServiceLevelAgreementPeriod { get; init; } 
    #else
    public Period3? ServiceLevelAgreementPeriod { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies a reason why a corporate action will not be supported by the validation service. This is usually due to the event type or the product (security) type. The list of values will be provided externally to the schema.
    /// </summary>
    [IsoId("_1lQOQDL3EeKU9IrkkToqcw_-1256134176")]
    [DisplayName("Validation Not Supported Reason")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="VldtnNotSpprtdRsn")]
    #endif
    [IsoXmlTag("VldtnNotSpprtdRsn")]
    [IsoSimpleType(IsoSimpleType.Max4AlphaNumericText)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4AlphaNumericText? ValidationNotSupportedReason { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ValidationNotSupportedReason { get; init; } 
    #else
    public System.String? ValidationNotSupportedReason { get; set; } 
    #endif
    
    
    #nullable disable
    
}
