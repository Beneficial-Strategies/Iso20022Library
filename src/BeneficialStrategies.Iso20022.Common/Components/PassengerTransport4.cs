// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Passenger ticket information for the cardholder.
/// </summary>
[IsoId("_FSx7sUhsEfCMZJtj4J7UGQ")]
[DisplayName("Passenger Transport4")]
public record PassengerTransport4
{
    /// <summary>
    /// Unique identification number of the document.
    /// </summary>
    [IsoId("_FVeqYUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    public IsoMax35Text? DocumentNumber { get; init; }

    /// <summary>
    /// Computerised reservation system used to make the reservation and purchase the ticket.
    /// </summary>
    [IsoId("_FVeqY0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Reservation System")]
    [IsoXmlTag("RsvatnSys")]
    public IsoMax4Text? ReservationSystem { get; init; }

    /// <summary>
    /// Value that uniquely identifies the reservation.
    /// </summary>
    [IsoId("_FVeqZUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Reservation Number")]
    [IsoXmlTag("RsvatnNb")]
    public IsoMax35Text? ReservationNumber { get; init; }

    /// <summary>
    /// System code that identifies the original reservation system used to make the reservation and purchase the ticket.
    /// </summary>
    [IsoId("_FVeqZ0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Original Reservation System")]
    [IsoXmlTag("OrgnlRsvatnSys")]
    public IsoMax4Text? OriginalReservationSystem { get; init; }

    /// <summary>
    /// Value that identifies the original reservation generated during the original reservation and purchase of the ticket.
    /// </summary>
    [IsoId("_FVeqaUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Original Reservation Number")]
    [IsoXmlTag("OrgnlRsvatnNb")]
    public IsoMax35Text? OriginalReservationNumber { get; init; }

    /// <summary>
    /// Contains a code provided to a travel agent by a company to authorise ticket issuance.
    /// </summary>
    [IsoId("_FVeqa0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Travel Authorisation Code")]
    [IsoXmlTag("TrvlAuthstnCd")]
    public IsoMax70Text? TravelAuthorisationCode { get; init; }

    /// <summary>
    /// Name of the issuing ticket agent.
    /// </summary>
    [IsoId("_FVeqbUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Ticket Issuer")]
    [IsoXmlTag("TcktIssr")]
    public IsoMax35Text? TicketIssuer { get; init; }

    /// <summary>
    /// Indicates whether or not the ticket is open or restricted.
    /// </summary>
    [IsoId("_FVeqb0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Open Ticket")]
    [IsoXmlTag("OpnTckt")]
    public IsoTrueFalseIndicator? OpenTicket { get; init; }

    /// <summary>
    /// Contains Customer Reference Values provided for this transaction.
    /// </summary>
    [IsoId("_FVeqcUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    public ValueList<CustomerReference1> CustomerReference { get; init; } = [];

    /// <summary>
    /// Contains the details of the passenger.
    /// </summary>
    [IsoId("_FVeqc0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Passenger")]
    [IsoXmlTag("Pssngr")]
    public ValueList<Customer10> Passenger { get; init; } = [];

    /// <summary>
    /// Contains departure location, date and time.
    /// </summary>
    [IsoId("_FVeqdUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Departure")]
    [IsoXmlTag("Dprture")]
    public DepartureOrArrival1? Departure { get; init; }

    /// <summary>
    /// Duration of the trip in days.
    /// </summary>
    [IsoId("_FVeqd0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_FVeqeUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    /// <summary>
    /// Total amount.
    /// </summary>
    [IsoId("_FVeqe0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ValueList<AmountAndTax1> TotalAmount { get; init; } = [];

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_FVeqfUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Loyalty programme details.
    /// </summary>
    [IsoId("_FVeqf0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme4? LoyaltyProgramme { get; init; }

    /// <summary>
    /// Component supports ticketing transactions for airline, railway, and travel agency transactions to provide passenger ticket information for the cardholder.
    /// </summary>
    [IsoId("_FVeqgUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Trip Leg")]
    [IsoXmlTag("TripLeg")]
    public ValueList<TripLeg4> TripLeg { get; init; } = [];

    /// <summary>
    /// Contains additional charges related to or during transit.
    /// </summary>
    [IsoId("_FVeqg0hsEfCMZJtj4J7UGQ")]
    [DisplayName("Ancillary Purchase")]
    [IsoXmlTag("AncllryPurchs")]
    public ValueList<AncillaryPurchase4> AncillaryPurchase { get; init; } = [];

    /// <summary>
    /// Vehicle for hire for passenger transport.
    /// </summary>
    [IsoId("_FVeqhUhsEfCMZJtj4J7UGQ")]
    [DisplayName("Hired Vehicle Details")]
    [IsoXmlTag("HirdVhclDtls")]
    public ValueList<HiredVehicle4> HiredVehicleDetails { get; init; } = [];

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_7p588khrEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_7p5880hrEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
