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
/// Contains the reservation details
/// </summary>
[IsoId("_tCvU1PPiEeihCvvpsmGI2w")]
[DisplayName("Reservation Details")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record ReservationDetails3
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Computerised reservation system used to make the reservation and purchase the ticket.
    /// </summary>
    [IsoId("_tCvU1_PiEeihCvvpsmGI2w")]
    [DisplayName("System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Sys")]
    #endif
    [IsoXmlTag("Sys")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? System { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? System { get; init; } 
    #else
    public System.String? System { get; set; } 
    #endif
    
    /// <summary>
    /// Value that uniquely identifies the reservation. 
    /// </summary>
    [IsoId("_tCvU1vPiEeihCvvpsmGI2w")]
    [DisplayName("Reservation Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RsvatnNb")]
    #endif
    [IsoXmlTag("RsvatnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? ReservationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? ReservationNumber { get; init; } 
    #else
    public System.String? ReservationNumber { get; set; } 
    #endif
    
    /// <summary>
    /// System code that identifies the original reservation system used to make the reservation and purchase the ticket. 
    /// </summary>
    [IsoId("_tCvU1fPiEeihCvvpsmGI2w")]
    [DisplayName("Original System")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlSys")]
    #endif
    [IsoXmlTag("OrgnlSys")]
    [IsoSimpleType(IsoSimpleType.Max4Text)]
    [StringLength(maximumLength: 4 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax4Text? OriginalSystem { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalSystem { get; init; } 
    #else
    public System.String? OriginalSystem { get; set; } 
    #endif
    
    /// <summary>
    /// Value that identifies the original reservation generated during the original reservation and purchase of the ticket. 
    /// </summary>
    [IsoId("_1YJEEfPjEeihCvvpsmGI2w")]
    [DisplayName("Original Reservation Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="OrgnlRsvatnNb")]
    #endif
    [IsoXmlTag("OrgnlRsvatnNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? OriginalReservationNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? OriginalReservationNumber { get; init; } 
    #else
    public System.String? OriginalReservationNumber { get; set; } 
    #endif
    
    
    #nullable disable
    
}
