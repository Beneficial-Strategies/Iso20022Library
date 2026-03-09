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
/// Defines the criteria used to report on reservation.
/// </summary>
[IsoId("_kuH-C5laEeeE1Ya-LgRsuQ")]
[DisplayName("Reservation Return Criteria")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReservationReturnCriteria1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Indicates whether the reservation start date time is requested.
    /// </summary>
    [IsoId("_k2a-YZlaEeeE1Ya-LgRsuQ")]
    [DisplayName("Start Date Time Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StartDtTmInd")]
    #endif
    [IsoXmlTag("StartDtTmInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? StartDateTimeIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StartDateTimeIndicator { get; init; } 
    #else
    public System.String? StartDateTimeIndicator { get; set; } 
    #endif
    
    /// <summary>
    /// Indicates whether the reservation status is requested.
    /// </summary>
    [IsoId("_k2a-Y5laEeeE1Ya-LgRsuQ")]
    [DisplayName("Status Indicator")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="StsInd")]
    #endif
    [IsoXmlTag("StsInd")]
    [IsoSimpleType(IsoSimpleType.RequestedIndicator)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoRequestedIndicator? StatusIndicator { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? StatusIndicator { get; init; } 
    #else
    public System.String? StatusIndicator { get; set; } 
    #endif
    
    
    #nullable disable
    
}
