// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Passenger ticket information for the cardholder. 
/// </summary>
[IsoId("_E2tJY_QcEeihCvvpsmGI2w")]
[DisplayName("Passenger Transport")]
public partial record PassengerTransport1
{
    #nullable enable
    
    /// <summary>
    /// Component supports ticketing transactions for airline, railway, and travel agency transactions to provide passenger ticket information for the cardholder. Acquirers can submit one occurrence of this component for each airline, railway, or travel agency transaction to provide general ticket information.
    /// </summary>
    [IsoId("_E2tJZfQcEeihCvvpsmGI2w")]
    [DisplayName("Summary")]
    [IsoXmlTag("Summry")]
    public PassengerTransportSummary1? Summary { get; init; } 
    
    /// <summary>
    /// Component supports ticketing transactions for airline, railway, and travel agency transactions to provide passenger ticket information for the cardholder. Acquirers can submit multiple occurrences of this component for each airline, railway, or travel agency transaction to provide general ticket information.
    /// </summary>
    [IsoId("_E2tJZPQcEeihCvvpsmGI2w")]
    [DisplayName("Trip Leg")]
    [IsoXmlTag("TripLeg")]
    public TripLeg1? TripLeg { get; init; } 
    
    /// <summary>
    /// Contains additional charges related to or during transit (for example, baggage fee, in-flight purchase). These are separate from the original ticket purchase.
    /// </summary>
    [IsoId("_oA_s4PQcEeihCvvpsmGI2w")]
    [DisplayName("Ancillary Purchase")]
    [IsoXmlTag("AncllryPurchs")]
    public AncillaryPurchase1? AncillaryPurchase { get; init; } 
    
    /// <summary>
    /// Vehicle for hire for passenger transport - excludes vehicles driven by a renter.  Examples include, but are not limited to, taxi, chauffered limousine, boats.
    /// </summary>
    [IsoId("_3YFysPQcEeihCvvpsmGI2w")]
    [DisplayName("Hired Vehicle Details")]
    [IsoXmlTag("HirdVhclDtls")]
    public HiredVehicle1? HiredVehicleDetails { get; init; } 
    
    
    #nullable disable
    
}
