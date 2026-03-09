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
[IsoId("_TmHJH9p-Ed-ak6NoX_4Aeg_-30513816")]
[DisplayName("Entitlement Assessment")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record EntitlementAssessment1
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
    [IsoId("_TmQTANp-Ed-ak6NoX_4Aeg_-30513814")]
    [DisplayName("Securities Blocking Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBlckgDdln")]
    #endif
    [IsoXmlTag("SctiesBlckgDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? SecuritiesBlockingDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? SecuritiesBlockingDeadline { get; init; } 
    #else
    public DateFormat2Choice_? SecuritiesBlockingDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by the issuer. (STP mode).
    /// </summary>
    [IsoId("_TmQTAdp-Ed-ak6NoX_4Aeg_2054659303")]
    [DisplayName("Securities Blocking STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBlckgSTPDdln")]
    #endif
    [IsoXmlTag("SctiesBlckgSTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? SecuritiesBlockingSTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? SecuritiesBlockingSTPDeadline { get; init; } 
    #else
    public DateFormat2Choice_? SecuritiesBlockingSTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the securities should be blocked. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_TmQTAtp-Ed-ak6NoX_4Aeg_-30513799")]
    [DisplayName("Securities Blocking Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="SctiesBlckgMktDdln")]
    #endif
    [IsoXmlTag("SctiesBlckgMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? SecuritiesBlockingMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? SecuritiesBlockingMarketDeadline { get; init; } 
    #else
    public DateFormat2Choice_? SecuritiesBlockingMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the blocking period for the securities should end.
    /// </summary>
    [IsoId("_TmQTA9p-Ed-ak6NoX_4Aeg_-30513781")]
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
    /// Date at which the positions are struck to note which parties will receive the entitlement, e.g. record date, book close date.
    /// </summary>
    [IsoId("_TmQTBNp-Ed-ak6NoX_4Aeg_-30513444")]
    [DisplayName("Entitlement Fixing Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitlmntFxgDt")]
    #endif
    [IsoXmlTag("EntitlmntFxgDt")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat3Choice_? EntitlementFixingDate { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat3Choice_? EntitlementFixingDate { get; init; } 
    #else
    public DateFormat3Choice_? EntitlementFixingDate { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_TmQTBdp-Ed-ak6NoX_4Aeg_-120826273")]
    [DisplayName("Registration Securities Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnSctiesDdln")]
    #endif
    [IsoXmlTag("RegnSctiesDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? RegistrationSecuritiesDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? RegistrationSecuritiesDeadline { get; init; } 
    #else
    public DateFormat2Choice_? RegistrationSecuritiesDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    [IsoId("_TmQTBtp-Ed-ak6NoX_4Aeg_46327692")]
    [DisplayName("Registration Securities STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnSctiesSTPDdln")]
    #endif
    [IsoXmlTag("RegnSctiesSTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? RegistrationSecuritiesSTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? RegistrationSecuritiesSTPDeadline { get; init; } 
    #else
    public DateFormat2Choice_? RegistrationSecuritiesSTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the securities have to be registered. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_TmQTB9p-Ed-ak6NoX_4Aeg_305836980")]
    [DisplayName("Registration Securities Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnSctiesMktDdln")]
    #endif
    [IsoXmlTag("RegnSctiesMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? RegistrationSecuritiesMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? RegistrationSecuritiesMarketDeadline { get; init; } 
    #else
    public DateFormat2Choice_? RegistrationSecuritiesMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is specified by an intermediary.
    /// </summary>
    [IsoId("_TmQTCNp-Ed-ak6NoX_4Aeg_453602280")]
    [DisplayName("Registration Participation Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnPrtcptnDdln")]
    #endif
    [IsoXmlTag("RegnPrtcptnDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? RegistrationParticipationDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? RegistrationParticipationDeadline { get; init; } 
    #else
    public DateFormat2Choice_? RegistrationParticipationDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is specified by an intermediary (STP mode).
    /// </summary>
    [IsoId("_TmQTCdp-Ed-ak6NoX_4Aeg_722345516")]
    [DisplayName("Registration Participation STP Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnPrtcptnSTPDdln")]
    #endif
    [IsoXmlTag("RegnPrtcptnSTPDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? RegistrationParticipationSTPDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? RegistrationParticipationSTPDeadline { get; init; } 
    #else
    public DateFormat2Choice_? RegistrationParticipationSTPDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Date by which the holder needs to register its intention to participate in the meeting process in order to be allowed to participate in the meeting event. This deadline is set by the issuer.
    /// </summary>
    [IsoId("_TmaEANp-Ed-ak6NoX_4Aeg_735277287")]
    [DisplayName("Registration Participation Market Deadline")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RegnPrtcptnMktDdln")]
    #endif
    [IsoXmlTag("RegnPrtcptnMktDdln")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public DateFormat2Choice_? RegistrationParticipationMarketDeadline { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public DateFormat2Choice_? RegistrationParticipationMarketDeadline { get; init; } 
    #else
    public DateFormat2Choice_? RegistrationParticipationMarketDeadline { get; set; } 
    #endif
    
    /// <summary>
    /// Specifies the calculation method of the number of votes assigned to one security. This element should be used when the entitlement calculation rule is complex.
    /// </summary>
    [IsoId("_TmaEAdp-Ed-ak6NoX_4Aeg_-30513409")]
    [DisplayName("Entitlement Description")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitlmntDesc")]
    #endif
    [IsoXmlTag("EntitlmntDesc")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax350Text? EntitlementDescription { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? EntitlementDescription { get; init; } 
    #else
    public System.String? EntitlementDescription { get; set; } 
    #endif
    
    /// <summary>
    /// Number of votes assigned to one security.
    /// </summary>
    [IsoId("_TmaEAtp-Ed-ak6NoX_4Aeg_-30513427")]
    [DisplayName("Entitlement Ratio")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="EntitlmntRatio")]
    #endif
    [IsoXmlTag("EntitlmntRatio")]
    [IsoSimpleType(IsoSimpleType.DecimalNumber)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoDecimalNumber? EntitlementRatio { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.UInt64? EntitlementRatio { get; init; } 
    #else
    public System.UInt64? EntitlementRatio { get; set; } 
    #endif
    
    
    #nullable disable
    
}
