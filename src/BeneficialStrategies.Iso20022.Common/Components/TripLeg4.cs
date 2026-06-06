// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Supplies additional transaction information for travel transactions.
/// </summary>
[IsoId("_2gCMMUiDEfCMZJtj4J7UGQ")]
[DisplayName("Trip Leg4")]
public record TripLeg4
{
    /// <summary>
    /// Identifies the specific occurrence of trip leg data.
    /// </summary>
    [IsoId("_2id1IUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Sequence Number")]
    [IsoXmlTag("SeqNb")]
    public IsoMax35NumericText? SequenceNumber { get; init; }

    /// <summary>
    /// Contains the ticket number.
    /// </summary>
    [IsoId("_2id1I0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Ticket Number")]
    [IsoXmlTag("TcktNb")]
    public IsoMax35Text? TicketNumber { get; init; }

    /// <summary>
    /// Name of the issuing ticket agent.
    /// </summary>
    [IsoId("_2id1JUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Ticket Issuer")]
    [IsoXmlTag("TcktIssr")]
    public IsoMax35Text? TicketIssuer { get; init; }

    /// <summary>
    /// Date the ticket was issued.
    /// </summary>
    [IsoId("_2id1J0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Ticket Issue Date")]
    [IsoXmlTag("TcktIsseDt")]
    public IsoISODate? TicketIssueDate { get; init; }

    /// <summary>
    /// Location where ticket was issued.
    /// </summary>
    [IsoId("_2id1KUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Ticket Issue Location")]
    [IsoXmlTag("TcktIsseLctn")]
    public IsoMax140Text? TicketIssueLocation { get; init; }

    /// <summary>
    /// Number of a ticket that contains additional coupons for an itinerary that contains more than four segments.
    /// </summary>
    [IsoId("_2id1K0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Conjunction Ticket Number")]
    [IsoXmlTag("CnjnctnTcktNb")]
    public IsoMax35Text? ConjunctionTicketNumber { get; init; }

    /// <summary>
    /// Indicates whether or not restrictions apply to the ticket.
    /// </summary>
    [IsoId("_2id1LUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Restricted Ticket")]
    [IsoXmlTag("RstrctdTckt")]
    public IsoTrueFalseIndicator? RestrictedTicket { get; init; }

    /// <summary>
    /// Indicates whether or not the ticket is open-ended.
    /// </summary>
    [IsoId("_2id1L0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Open Ticket")]
    [IsoXmlTag("OpnTckt")]
    public IsoTrueFalseIndicator? OpenTicket { get; init; }

    /// <summary>
    /// Contains the specific restriction applicable to the ticket.
    /// </summary>
    [IsoId("_2id1MUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Ticket Restrictions")]
    [IsoXmlTag("TcktRstrctns")]
    public IsoMax70Text? TicketRestrictions { get; init; }

    /// <summary>
    /// Indicates whether or not the ticket was exchanged (reissued or new ticket generated).
    /// </summary>
    [IsoId("_2id1M0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Exchanged Ticket")]
    [IsoXmlTag("XchgdTckt")]
    public IsoTrueFalseIndicator? ExchangedTicket { get; init; }

    /// <summary>
    /// Contains the original ticket number that was replaced by the new ticket number.
    /// </summary>
    [IsoId("_2id1NUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Exchanged Ticket Number")]
    [IsoXmlTag("XchgdTcktNb")]
    public IsoMax35Text? ExchangedTicketNumber { get; init; }

    /// <summary>
    /// Ticket record locator number.
    /// </summary>
    [IsoId("_2id1N0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Record Locator Number")]
    [IsoXmlTag("RcrdLctrNb")]
    public IsoMax35Text? RecordLocatorNumber { get; init; }

    /// <summary>
    /// Computerised reservation system used to make the reservation and purchase the ticket.
    /// </summary>
    [IsoId("_2id1OUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Reservation System")]
    [IsoXmlTag("RsvatnSys")]
    public IsoMax4Text? ReservationSystem { get; init; }

    /// <summary>
    /// Value that uniquely identifies the reservation.
    /// </summary>
    [IsoId("_2id1O0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Reservation Number")]
    [IsoXmlTag("RsvatnNb")]
    public IsoMax35Text? ReservationNumber { get; init; }

    /// <summary>
    /// System code that identifies the original reservation system used to make the reservation and purchase the ticket.
    /// </summary>
    [IsoId("_2id1PUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Original Reservation System")]
    [IsoXmlTag("OrgnlRsvatnSys")]
    public IsoMax4Text? OriginalReservationSystem { get; init; }

    /// <summary>
    /// Value that identifies the original reservation generated during the original reservation and purchase of the ticket.
    /// </summary>
    [IsoId("_2id1P0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Original Reservation Number")]
    [IsoXmlTag("OrgnlRsvatnNb")]
    public IsoMax35Text? OriginalReservationNumber { get; init; }

    /// <summary>
    /// Provides the reference documentation.
    /// </summary>
    [IsoId("_2id1QUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Document")]
    [IsoXmlTag("Doc")]
    public IsoATICALaxProcessing? Document { get; init; }

    /// <summary>
    /// Type of transportation. P000-P999 reserved for private use, N000-N999 reserved for national use.
    /// </summary>
    [IsoId("_2id1Q0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Transport Type")]
    [IsoXmlTag("TrnsprtTp")]
    public TransportType2Code? TransportType { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_2id1R0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Commodity Code")]
    [IsoXmlTag("CmmdtyCd")]
    public IsoMax4Text? CommodityCode { get; init; }

    /// <summary>
    /// Name of the transportation carrier.
    /// </summary>
    [IsoId("_2id1SUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Carrier Name")]
    [IsoXmlTag("CrrierNm")]
    public IsoMax70Text? CarrierName { get; init; }

    /// <summary>
    /// Identifies the operator (company providing service).
    /// </summary>
    [IsoId("_2id1S0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Carrier Code")]
    [IsoXmlTag("CrrierCd")]
    public IsoMax35Text? CarrierCode { get; init; }

    /// <summary>
    /// Contains the International Air Transport Association (IATA) code identifying the company that purchased the ticket.
    /// </summary>
    [IsoId("_2id1TUiDEfCMZJtj4J7UGQ")]
    [DisplayName("IATA Code")]
    [IsoXmlTag("IATACd")]
    public IsoMax35Text? IATACode { get; init; }

    /// <summary>
    /// Route number as specified by the transportation carrier (for example, flight number, bus number, train route or number, etc.)
    /// </summary>
    [IsoId("_2id1T0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Route Number")]
    [IsoXmlTag("RouteNb")]
    public IsoMax35Text? RouteNumber { get; init; }

    /// <summary>
    /// Indicates the service class (for example, coach or first class).
    /// </summary>
    [IsoId("_2id1UUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Service Class")]
    [IsoXmlTag("SvcClss")]
    public IsoMax35Text? ServiceClass { get; init; }

    /// <summary>
    /// Contains departure location, date and time.
    /// </summary>
    [IsoId("_2id1U0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Departure")]
    [IsoXmlTag("Dprture")]
    public DepartureOrArrival1? Departure { get; init; }

    /// <summary>
    /// Contains arrival location, date and time.
    /// </summary>
    [IsoId("_2id1VUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Arrival")]
    [IsoXmlTag("Arrvl")]
    public DepartureOrArrival1? Arrival { get; init; }

    /// <summary>
    /// Duration of the trip.
    /// </summary>
    [IsoId("_2id1V0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Indicator that specifies whether the mode of transportation was a direct or non-direct route on the same ticket number.
    /// </summary>
    [IsoId("_2id1WUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Stop Over")]
    [IsoXmlTag("StopOver")]
    public IsoTrueFalseIndicator? StopOver { get; init; }

    /// <summary>
    /// Indicates a non-direct route between the origin and the destination.
    /// </summary>
    [IsoId("_2id1W0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Non Direct Route Code")]
    [IsoXmlTag("NonDrctRouteCd")]
    public IsoMax35Text? NonDirectRouteCode { get; init; }

    /// <summary>
    /// Code that transportation companies assign to a particular ticket type, such as business class or discounted or non-refundable tickets.
    /// </summary>
    [IsoId("_2id1XUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Fair Basis Code")]
    [IsoXmlTag("FairBsisCd")]
    public IsoMax35Text? FairBasisCode { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_2id1X0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Insurance")]
    [IsoXmlTag("Insrnc")]
    public IsoTrueFalseIndicator? Insurance { get; init; }

    /// <summary>
    /// Contains trip leg amount information.
    /// </summary>
    [IsoId("_2id1YUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Amount")]
    [IsoXmlTag("Amt")]
    public ValueList<AmountAndTax1> Amount { get; init; } = [];

    /// <summary>
    /// Indicates reason for the credit to the cardholder. Includes: ancillary purchase cancelled, passenger transport ticket and related ancillary purchase cancelled, etc.
    /// </summary>
    [IsoId("_2id1Y0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Credit Reason Code")]
    [IsoXmlTag("CdtRsnCd")]
    public IsoMax35Text? CreditReasonCode { get; init; }

    /// <summary>
    /// Contains identification of the rail server procedure or the order in which the service was booked or a cancellation was completed.
    /// </summary>
    [IsoId("_2id1ZUiDEfCMZJtj4J7UGQ")]
    [DisplayName("Procedure Identification")]
    [IsoXmlTag("PrcdrId")]
    public IsoMax35Text? ProcedureIdentification { get; init; }

    /// <summary>
    /// Loyalty programme details.
    /// </summary>
    [IsoId("_2id1Z0iDEfCMZJtj4J7UGQ")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme4? LoyaltyProgramme { get; init; }

    /// <summary>
    /// Reserved for private data. The use of this data element is determined by bilateral agreement.
    /// </summary>
    [IsoId("_03GfgkiDEfCMZJtj4J7UGQ")]
    [DisplayName("Private Data")]
    [IsoXmlTag("PrvtData")]
    public SimpleValueList<IsoATICALaxProcessing> PrivateData { get; init; } = [];

    /// <summary>
    /// Reserved to define data unique to the country applications.
    /// </summary>
    [IsoId("_03Gfg0iDEfCMZJtj4J7UGQ")]
    [DisplayName("National Data")]
    [IsoXmlTag("NtlData")]
    public SimpleValueList<IsoATICALaxProcessing> NationalData { get; init; } = [];
}
