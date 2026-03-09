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
/// Specifies the parameters, such as dates, used to calculate the entitlement to vote at a general meeting.
/// </summary>
[IsoId("_HEDOEVuDEeSmO6RkXg92Lg")]
[DisplayName("Entitlement Assessment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EntitlementAssessment3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by an intermediary.
    /// </summary>
    [IsoId("_HfuddVuDEeSmO6RkXg92Lg")]
    [DisplayName("Securities Blocking Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBlckgDdln")]
    #endif
    [IsoXmlTag("SctiesBlckgDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? SecuritiesBlockingDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? SecuritiesBlockingDeadline { get; init; } 
    #else
    public DateFormat29Choice_? SecuritiesBlockingDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by the issuer (STP mode).
    /// </summary>
    [IsoId("_Hfudd1uDEeSmO6RkXg92Lg")]
    [DisplayName("Securities Blocking STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBlckgSTPDdln")]
    #endif
    [IsoXmlTag("SctiesBlckgSTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? SecuritiesBlockingSTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? SecuritiesBlockingSTPDeadline { get; init; } 
    #else
    public DateFormat29Choice_? SecuritiesBlockingSTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_HfudeVuDEeSmO6RkXg92Lg")]
    [DisplayName("Securities Blocking Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBlckgMktDdln")]
    #endif
    [IsoXmlTag("SctiesBlckgMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? SecuritiesBlockingMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? SecuritiesBlockingMarketDeadline { get; init; } 
    #else
    public DateFormat29Choice_? SecuritiesBlockingMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the blocking period for the securities should end.
    /// </summary>
    [IsoId("_Hfude1uDEeSmO6RkXg92Lg")]
    [DisplayName("Securities Blocking Period End Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBlckgPrdEndDt")]
    #endif
    [IsoXmlTag("SctiesBlckgPrdEndDt")]
    [IsoSimpleType(IsoSimpleType.ISODateTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODateTime? SecuritiesBlockingPeriodEndDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateTime? SecuritiesBlockingPeriodEndDate { get; init; } 
    #else
    public System.DateTime? SecuritiesBlockingPeriodEndDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date at which the positions are struck to note which parties will receive the entitlement, for example. record date, book close date.
    /// </summary>
    [IsoId("_HfudfVuDEeSmO6RkXg92Lg")]
    [DisplayName("Entitlement Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitlmntFxgDt")]
    #endif
    [IsoXmlTag("EntitlmntFxgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat1? EntitlementFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat1? EntitlementFixingDate { get; init; } 
    #else
    public DateFormat1? EntitlementFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_Hfudf1uDEeSmO6RkXg92Lg")]
    [DisplayName("Registration Securities Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnSctiesDdln")]
    #endif
    [IsoXmlTag("RegnSctiesDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? RegistrationSecuritiesDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? RegistrationSecuritiesDeadline { get; init; } 
    #else
    public DateFormat29Choice_? RegistrationSecuritiesDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    [IsoId("_HfudgVuDEeSmO6RkXg92Lg")]
    [DisplayName("Registration Securities STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnSctiesSTPDdln")]
    #endif
    [IsoXmlTag("RegnSctiesSTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? RegistrationSecuritiesSTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? RegistrationSecuritiesSTPDeadline { get; init; } 
    #else
    public DateFormat29Choice_? RegistrationSecuritiesSTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_Hfudg1uDEeSmO6RkXg92Lg")]
    [DisplayName("Registration Securities Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnSctiesMktDdln")]
    #endif
    [IsoXmlTag("RegnSctiesMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? RegistrationSecuritiesMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? RegistrationSecuritiesMarketDeadline { get; init; } 
    #else
    public DateFormat29Choice_? RegistrationSecuritiesMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_HfudhVuDEeSmO6RkXg92Lg")]
    [DisplayName("Registration Participation Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnPrtcptnDdln")]
    #endif
    [IsoXmlTag("RegnPrtcptnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? RegistrationParticipationDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? RegistrationParticipationDeadline { get; init; } 
    #else
    public DateFormat29Choice_? RegistrationParticipationDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    [IsoId("_Hfudh1uDEeSmO6RkXg92Lg")]
    [DisplayName("Registration Participation STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnPrtcptnSTPDdln")]
    #endif
    [IsoXmlTag("RegnPrtcptnSTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? RegistrationParticipationSTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? RegistrationParticipationSTPDeadline { get; init; } 
    #else
    public DateFormat29Choice_? RegistrationParticipationSTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_HfudiVuDEeSmO6RkXg92Lg")]
    [DisplayName("Registration Participation Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnPrtcptnMktDdln")]
    #endif
    [IsoXmlTag("RegnPrtcptnMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat29Choice_? RegistrationParticipationMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat29Choice_? RegistrationParticipationMarketDeadline { get; init; } 
    #else
    public DateFormat29Choice_? RegistrationParticipationMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes assigned to one security.
    /// </summary>
    [IsoId("_Hfudi1uDEeSmO6RkXg92Lg")]
    [DisplayName("Entitlement")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Entitlmnt")]
    #endif
    [IsoXmlTag("Entitlmnt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public Entitlement1Choice_? Entitlement { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public Entitlement1Choice_? Entitlement { get; init; } 
    #else
    public Entitlement1Choice_? Entitlement { get; set; } 
    #endif
    
    
    #nullable disable
    
}
