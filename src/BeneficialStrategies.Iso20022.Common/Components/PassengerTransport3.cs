// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Passenger Transport3.
/// </summary>
[IsoId("_8chqQXQ7Ee6Y1uOeeiF_Eg")]
[DisplayName("Passenger Transport3")]
public partial record PassengerTransport3
{
    #nullable enable

    /// <summary>
    /// Additional Data.
    /// </summary>
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    public ValueList<AdditionalData1> AdditionalData { get; init; } = [];

    /// <summary>
    /// Ancillary Purchase.
    /// </summary>
    [DisplayName("Ancillary Purchase")]
    [IsoXmlTag("AncllryPurchs")]
    public ValueList<AncillaryPurchase3> AncillaryPurchase { get; init; } = [];

    /// <summary>
    /// Customer Reference.
    /// </summary>
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    public ValueList<CustomerReference1> CustomerReference { get; init; } = [];

    /// <summary>
    /// Departure.
    /// </summary>
    [DisplayName("Departure")]
    [IsoXmlTag("Dprture")]
    public DepartureOrArrival1? Departure { get; init; } 

    /// <summary>
    /// Document Number.
    /// </summary>
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    public IsoMax35Text? DocumentNumber { get; init; } 

    /// <summary>
    /// Duration.
    /// </summary>
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoMax4NumericText? Duration { get; init; } 

    /// <summary>
    /// Hired Vehicle Details.
    /// </summary>
    [DisplayName("Hired Vehicle Details")]
    [IsoXmlTag("HirdVhclDtls")]
    public ValueList<HiredVehicle3> HiredVehicleDetails { get; init; } = [];

    /// <summary>
    /// Insurance.
    /// </summary>
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; } 

    /// <summary>
    /// Loyalty Programme.
    /// </summary>
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme4? LoyaltyProgramme { get; init; } 

    /// <summary>
    /// Open Ticket.
    /// </summary>
    [DisplayName("Open Ticket")]
    [IsoXmlTag("OpnTckt")]
    public IsoTrueFalseIndicator? OpenTicket { get; init; } 

    /// <summary>
    /// Original Reservation Number.
    /// </summary>
    [DisplayName("Original Reservation Number")]
    [IsoXmlTag("OrgnlRsvatnNb")]
    public IsoMax35Text? OriginalReservationNumber { get; init; } 

    /// <summary>
    /// Original Reservation System.
    /// </summary>
    [DisplayName("Original Reservation System")]
    [IsoXmlTag("OrgnlRsvatnSys")]
    public IsoMax4Text? OriginalReservationSystem { get; init; } 

    /// <summary>
    /// Passenger.
    /// </summary>
    [DisplayName("Passenger")]
    [IsoXmlTag("Pssngr")]
    public ValueList<Customer9> Passenger { get; init; } = [];

    /// <summary>
    /// Reservation Number.
    /// </summary>
    [DisplayName("Reservation Number")]
    [IsoXmlTag("RsvatnNb")]
    public IsoMax35Text? ReservationNumber { get; init; } 

    /// <summary>
    /// Reservation System.
    /// </summary>
    [DisplayName("Reservation System")]
    [IsoXmlTag("RsvatnSys")]
    public IsoMax4Text? ReservationSystem { get; init; } 

    /// <summary>
    /// Summary Commodity Identification.
    /// </summary>
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 

    /// <summary>
    /// Ticket Issuer.
    /// </summary>
    [DisplayName("Ticket Issuer")]
    [IsoXmlTag("TcktIssr")]
    public IsoMax35Text? TicketIssuer { get; init; } 

    /// <summary>
    /// Total Amount.
    /// </summary>
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ValueList<AmountDetails3> TotalAmount { get; init; } = [];

    /// <summary>
    /// Travel Authorisation Code.
    /// </summary>
    [DisplayName("Travel Authorisation Code")]
    [IsoXmlTag("TrvlAuthstnCd")]
    public IsoMax70Text? TravelAuthorisationCode { get; init; } 

    /// <summary>
    /// Trip Leg.
    /// </summary>
    [DisplayName("Trip Leg")]
    [IsoXmlTag("TripLeg")]
    public ValueList<TripLeg3> TripLeg { get; init; } = [];

    
    #nullable disable
    
}
