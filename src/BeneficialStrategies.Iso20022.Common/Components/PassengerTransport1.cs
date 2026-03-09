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
/// Passenger ticket information for the cardholder. 
/// </summary>
[IsoId("_E2tJY_QcEeihCvvpsmGI2w")]
[DisplayName("Passenger Transport")]
#if DECLARE_SERIALIZABLE
[Serializable]
#endif
#if DECLARE_DATACONTRACT
[DataContract]
#endif
public partial record PassengerTransport1
{
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    // No constructor needed for NET8 and above.
    #else
    // No constructor needed for < NET8 because this type has no required members.
    #endif
    #nullable enable
    
    /// <summary>
    /// Component supports ticketing transactions for airline, railway, and travel agency transactions to provide passenger ticket information for the cardholder. Acquirers can submit one occurrence of this component for each airline, railway, or travel agency transaction to provide general ticket information.
    /// </summary>
    [IsoId("_E2tJZfQcEeihCvvpsmGI2w")]
    [DisplayName("Summary")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="Summry")]
    #endif
    [IsoXmlTag("Summry")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public PassengerTransportSummary1? Summary { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public PassengerTransportSummary1? Summary { get; init; } 
    #else
    public PassengerTransportSummary1? Summary { get; set; } 
    #endif
    
    /// <summary>
    /// Component supports ticketing transactions for airline, railway, and travel agency transactions to provide passenger ticket information for the cardholder. Acquirers can submit multiple occurrences of this component for each airline, railway, or travel agency transaction to provide general ticket information.
    /// </summary>
    [IsoId("_E2tJZPQcEeihCvvpsmGI2w")]
    [DisplayName("Trip Leg")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="TripLeg")]
    #endif
    [IsoXmlTag("TripLeg")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public TripLeg1? TripLeg { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public TripLeg1? TripLeg { get; init; } 
    #else
    public TripLeg1? TripLeg { get; set; } 
    #endif
    
    /// <summary>
    /// Contains additional charges related to or during transit (for example, baggage fee, in-flight purchase). These are separate from the original ticket purchase.
    /// </summary>
    [IsoId("_oA_s4PQcEeihCvvpsmGI2w")]
    [DisplayName("Ancillary Purchase")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="AncllryPurchs")]
    #endif
    [IsoXmlTag("AncllryPurchs")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public AncillaryPurchase1? AncillaryPurchase { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public AncillaryPurchase1? AncillaryPurchase { get; init; } 
    #else
    public AncillaryPurchase1? AncillaryPurchase { get; set; } 
    #endif
    
    /// <summary>
    /// Vehicle for hire for passenger transport - excludes vehicles driven by a renter.  Examples include, but are not limited to, taxi, chauffered limousine, boats.
    /// </summary>
    [IsoId("_3YFysPQcEeihCvvpsmGI2w")]
    [DisplayName("Hired Vehicle Details")]
    #if DECLARE_DATACONTRACT
    [DataMember(Name="HirdVhclDtls")]
    #endif
    [IsoXmlTag("HirdVhclDtls")]
    #if NET8_0_OR_GREATER // C# 12 Global type alias
    public HiredVehicle1? HiredVehicleDetails { get; init; } 
    #elif NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public HiredVehicle1? HiredVehicleDetails { get; init; } 
    #else
    public HiredVehicle1? HiredVehicleDetails { get; set; } 
    #endif
    
    
    #nullable disable
    
}
