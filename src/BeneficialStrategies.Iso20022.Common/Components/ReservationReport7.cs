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
/// Reports either on the reservation or on a business error.
/// </summary>
[IsoId("_eJZtZdcZEeqRFcf2R4bPBw")]
[DisplayName("Reservation Report")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReservationReport7
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    /// <summary>
    /// Constructs a ReservationReport7 instance using the members the ISO20022 deems required.
    /// It is higly recommended that you update to .NET 8 or above so you can use required initialization syntax instead
    /// </summary>
    public ReservationReport7( ReservationIdentification3 reqReservationIdentification,ReservationOrError9Choice_ reqReservationOrError )
    {
        ReservationIdentification = reqReservationIdentification;
        ReservationOrError = reqReservationOrError;
    }
    #endif
    #nullable enable
    
    /// <summary>
    /// Identification of the reservation on which information is requested.
    /// </summary>
    [IsoId("_eK5iMdcZEeqRFcf2R4bPBw")]
    [DisplayName("Reservation Identification")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsvatnId")]
    #endif
    [IsoXmlTag("RsvatnId")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReservationIdentification3 ReservationIdentification { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReservationIdentification3 ReservationIdentification { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReservationIdentification3 ReservationIdentification { get; init; } 
    #else
    public ReservationIdentification3 ReservationIdentification { get; set; } 
    #endif
    
    /// <summary>
    /// Requested information on the limit.
    /// </summary>
    [IsoId("_eK5iM9cZEeqRFcf2R4bPBw")]
    [DisplayName("Reservation Or Error")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsvatnOrErr")]
    #endif
    [IsoXmlTag("RsvatnOrErr")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public required ReservationOrError9Choice_ ReservationOrError { get; init; } 
    #elif NET7_0_OR_GREATER // C# 11 Records, required members
    public required ReservationOrError9Choice_ ReservationOrError { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public ReservationOrError9Choice_ ReservationOrError { get; init; } 
    #else
    public ReservationOrError9Choice_ ReservationOrError { get; set; } 
    #endif
    
    
    #nullable disable
    
}
