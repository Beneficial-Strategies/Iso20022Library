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
/// Contains departure or arrival information.
/// </summary>
[IsoId("_Hqx1RfcWEeiW-auGnDPZIw")]
[DisplayName("Departure Or Arrival")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record DepartureOrArrival2
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Code indicating the name of the passenger transport carrier (for example, United Airlines, Lufthansa, JetBlue, etc.) 
    /// </summary>
    [IsoId("_Hqx1SfcWEeiW-auGnDPZIw")]
    [DisplayName("Carrier Code")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="CrrierCd")]
    #endif
    [IsoXmlTag("CrrierCd")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35Text? CarrierCode { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? CarrierCode { get; init; } 
    #else
    public System.String? CarrierCode { get; set; } 
    #endif
    
    /// <summary>
    /// Route number (for example, flight number, bus number, train route or number, etc.)
    /// </summary>
    [IsoId("_Hqx1SPcWEeiW-auGnDPZIw")]
    [DisplayName("Route Number")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="RouteNb")]
    #endif
    [IsoXmlTag("RouteNb")]
    [IsoSimpleType(IsoSimpleType.Max35NumericText)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoMax35NumericText? RouteNumber { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.String? RouteNumber { get; init; } 
    #else
    public System.String? RouteNumber { get; set; } 
    #endif
    
    /// <summary>
    /// Departure or arrival date.
    /// </summary>
    [IsoId("_Hqx1R_cWEeiW-auGnDPZIw")]
    [DisplayName("Date")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Dt")]
    #endif
    [IsoXmlTag("Dt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISODate? Date { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.DateOnly? Date { get; init; } 
    #else
    public System.DateOnly? Date { get; set; } 
    #endif
    
    /// <summary>
    /// Departure or arrival time. 
    /// </summary>
    [IsoId("_Hqx1RvcWEeiW-auGnDPZIw")]
    [DisplayName("Time")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Tm")]
    #endif
    [IsoXmlTag("Tm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public IsoISOTime? Time { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public System.TimeOnly? Time { get; init; } 
    #else
    public System.TimeOnly? Time { get; set; } 
    #endif
    
    
    #nullable disable
    
}
