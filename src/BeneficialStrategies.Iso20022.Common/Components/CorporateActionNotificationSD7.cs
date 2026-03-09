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
/// Provides additional information regarding corporate action general information details.
/// </summary>
[IsoId("_1l_1IzL3EeKU9IrkkToqcw_1617998570")]
[DisplayName("Corporate Action Notification SD")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record CorporateActionNotificationSD7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a CorporateActionNotificationSD7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public CorporateActionNotificationSD7( System.String reqPlaceAndName )
    {
        PlaceAndName = reqPlaceAndName;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// xPath to the element that is being extended.
    /// </summary>
    [IsoId("_1l_1JDL3EeKU9IrkkToqcw_-339709485")]
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
    /// DTC processing domain/ category for event types.
    /// </summary>
    [IsoId("_1l_1JTL3EeKU9IrkkToqcw_2074952171")]
    [DisplayName("Event Group")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtGrp")]
    #endif
    [IsoXmlTag("EvtGrp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public EventGroup1Code? EventGroup { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public EventGroup1Code? EventGroup { get; init; } 
    #else
    public EventGroup1Code? EventGroup { get; set; } 
    #endif
    
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action event type name. Used in place for the events that cannot be classified by ISO code and mapped to OTHR or when two or more distinct events (in DTCC model) use same ISO code and there are no additional data elements that distinguish those two or more events.
    /// </summary>
    [IsoId("_1l_1JjL3EeKU9IrkkToqcw_-284058947")]
    [DisplayName("Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EvtTp")]
    #endif
    [IsoXmlTag("EvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public ExtendedEventType1Code? EventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ExtendedEventType1Code? EventType { get; init; } 
    #else
    public ExtendedEventType1Code? EventType { get; set; } 
    #endif
    
    /// <summary>
    /// DTCC (The Depository Trust and Clearing Corporation) native corporate action sub event type name further defines the event type.
    /// </summary>
    [IsoId("_1mJmIDL3EeKU9IrkkToqcw_-1394970366")]
    [DisplayName("Sub Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SubEvtTp")]
    #endif
    [IsoXmlTag("SubEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DTCCSubEventType2Code? SubEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DTCCSubEventType2Code? SubEventType { get; init; } 
    #else
    public DTCCSubEventType2Code? SubEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the nature of the event with regard to how it is being supported by DTC (The Depository Trust Corporation) the custodian: whether the event is mandatory, voluntary, or mandatory with options and eligible for DTC processing. This classification is necessary for the event types that have additional DTC only options. For an example: a MAND event, where the issuer declared only one option may be eligible for special DTC options (services like Dividend Reinvestment, Foreign Currency Payment, etc) in this case it will be announced as MAND by the issuer and CHOS by DTC.
    /// </summary>
    [IsoId("_1mJmITL3EeKU9IrkkToqcw_1822832819")]
    [DisplayName("DTC Mandatory Voluntary Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DTCMndtryVlntryEvtTp")]
    #endif
    [IsoXmlTag("DTCMndtryVlntryEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionMandatoryVoluntary1Code? DTCMandatoryVoluntaryEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMandatoryVoluntary1Code? DTCMandatoryVoluntaryEventType { get; init; } 
    #else
    public CorporateActionMandatoryVoluntary1Code? DTCMandatoryVoluntaryEventType { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the nature of the event as announced by the agent or issuer.
    /// </summary>
    [IsoId("_1mJmIjL3EeKU9IrkkToqcw_-1171576516")]
    [DisplayName("Declared Mandatory Voluntary Event Type")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="DclrdMndtryVlntryEvtTp")]
    #endif
    [IsoXmlTag("DclrdMndtryVlntryEvtTp")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public CorporateActionMandatoryVoluntary1Code? DeclaredMandatoryVoluntaryEventType { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public CorporateActionMandatoryVoluntary1Code? DeclaredMandatoryVoluntaryEventType { get; init; } 
    #else
    public CorporateActionMandatoryVoluntary1Code? DeclaredMandatoryVoluntaryEventType { get; set; } 
    #endif
    
    
    #nullable disable
    
}
