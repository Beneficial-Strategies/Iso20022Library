// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Passenger ticket summary information for the cardholder.
/// </summary>
[IsoId("_YkXBm_PhEeihCvvpsmGI2w")]
[DisplayName("Passenger Transport Summary")]
public record PassengerTransportSummary1
{
    /// <summary>
    /// Unique identification number of the document.
    /// </summary>
    [IsoId("_OysdwfPiEeihCvvpsmGI2w")]
    [DisplayName("Document Number")]
    [IsoXmlTag("DocNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? DocumentNumber { get; init; }

    /// <summary>
    /// Reservation number or identifier.
    /// </summary>
    [IsoId("_YkXopvPhEeihCvvpsmGI2w")]
    [DisplayName("Reservation")]
    [IsoXmlTag("Rsvatn")]
    public ReservationDetails3? Reservation { get; init; }

    /// <summary>
    /// Contains a code provided to a travel agent by a company to authorise ticket issuance.
    /// </summary>
    [IsoId("_YkXoo_PhEeihCvvpsmGI2w")]
    [DisplayName("Travel Authorisation Code")]
    [IsoXmlTag("TrvlAuthstnCd")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? TravelAuthorisationCode { get; init; }

    /// <summary>
    /// Name of the issuing ticket agent.
    /// </summary>
    [IsoId("_YkXoqPPhEeihCvvpsmGI2w")]
    [DisplayName("Ticket Issuer")]
    [IsoXmlTag("TcktIssr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? TicketIssuer { get; init; }

    /// <summary>
    /// Indicates whether or not the ticket is open or restricted.
    /// </summary>
    [IsoId("_v7m4AfPlEeihCvvpsmGI2w")]
    [DisplayName("Open Ticket Indicator")]
    [IsoXmlTag("OpnTcktInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? OpenTicketIndicator { get; init; }

    /// <summary>
    /// Contains Customer Reference Values provided for this transaction and used for various reference processing at the customer site. These values represent information most prevalently provided by travel agencies for transactions booked against a lodged account or central travel account.
    /// </summary>
    [IsoId("_YkXooPPhEeihCvvpsmGI2w")]
    [DisplayName("Customer Reference")]
    [IsoXmlTag("CstmrRef")]
    public ValueList<CustomerReference1> CustomerReference { get; init; } = [];

    /// <summary>
    /// Contains the details of the passenger.
    /// </summary>
    [IsoId("_YkXopPPhEeihCvvpsmGI2w")]
    [DisplayName("Passenger")]
    [IsoXmlTag("Pssngr")]
    public ValueList<Customer5> Passenger { get; init; } = [];

    /// <summary>
    /// Contains departure location, date and time.
    /// </summary>
    [IsoId("_YkXoofPhEeihCvvpsmGI2w")]
    [DisplayName("Departure")]
    [IsoXmlTag("Dprture")]
    public DepartureOrArrival1? Departure { get; init; }

    /// <summary>
    /// Duration of the trip in days.
    /// </summary>
    [IsoId("_YkXopfPhEeihCvvpsmGI2w")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_YkXoovPhEeihCvvpsmGI2w")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Total amount.
    /// </summary>
    [IsoId("_YkXoqfPhEeihCvvpsmGI2w")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public AmountDetails1? TotalAmount { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_tPq8kvPtEeihCvvpsmGI2w")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Loyalty programme details.
    /// </summary>
    [IsoId("_tPq8k_PtEeihCvvpsmGI2w")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; }

    /// <summary>
    /// Additional user-defined data pertaining to the transportation.
    /// </summary>
    [IsoId("_YkXop_PhEeihCvvpsmGI2w")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
