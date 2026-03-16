// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Data pertaining to a lodging transaction.
/// </summary>
[IsoId("_npqEIPb_EeiW-auGnDPZIw")]
[DisplayName("Lodging Summary")]
public record LodgingSummary1
{
    /// <summary>
    /// Contains the lodging company&apos;s invoice or billing ID reference number, referred to as a folio number.
    /// </summary>
    [IsoId("_4mIMUfb_EeiW-auGnDPZIw")]
    [DisplayName("Folio Number")]
    [IsoXmlTag("FolioNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FolioNumber { get; init; }

    /// <summary>
    /// Details of the lodging property.
    /// </summary>
    [IsoId("_npqEIvb_EeiW-auGnDPZIw")]
    [DisplayName("Property")]
    [IsoXmlTag("Prprty")]
    public LodgingProperty1? Property { get; init; }

    /// <summary>
    /// Contains customer details.
    /// </summary>
    [IsoId("_npqEJPb_EeiW-auGnDPZIw")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public Customer5? Customer { get; init; }

    /// <summary>
    /// Number of rooms within the reservation.
    /// </summary>
    [IsoId("_LIyYwPcMEeiW-auGnDPZIw")]
    [DisplayName("Number Of Rooms")]
    [IsoXmlTag("NbOfRooms")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? NumberOfRooms { get; init; }

    /// <summary>
    /// Contains the room details.
    /// </summary>
    [IsoId("_npqEI_b_EeiW-auGnDPZIw")]
    [DisplayName("Room")]
    [IsoXmlTag("Room")]
    public LodgingRoom1? Room { get; init; }

    /// <summary>
    /// Duration of stay in days.
    /// </summary>
    [IsoId("_zIKFxPcVEeiW-auGnDPZIw")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Lodging transaction details.
    /// </summary>
    [IsoId("_npqEIfb_EeiW-auGnDPZIw")]
    [DisplayName("Arrival")]
    [IsoXmlTag("Arrvl")]
    public DepartureOrArrival2? Arrival { get; init; }

    /// <summary>
    /// Contains departure details.
    /// </summary>
    [IsoId("_CbURUPcXEeiW-auGnDPZIw")]
    [DisplayName("Departure")]
    [IsoXmlTag("Dprture")]
    public DepartureOrArrival1? Departure { get; init; }

    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee; property was not actually rented.
    /// </summary>
    [IsoId("_fKVag_cXEeiW-auGnDPZIw")]
    [DisplayName("No Show Indicator")]
    [IsoXmlTag("NoShowInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NoShowIndicator { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_zIKFxfcVEeiW-auGnDPZIw")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Amount of insurance.
    /// </summary>
    [IsoId("_-Xv4wPcXEeiW-auGnDPZIw")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_fKVahfcXEeiW-auGnDPZIw")]
    [DisplayName("Total Tax")]
    [IsoXmlTag("TtlTax")]
    public Tax33? TotalTax { get; init; }

    /// <summary>
    /// Contains the total amount of lodging expenses.
    /// </summary>
    [IsoId("_GYQLgPcYEeiW-auGnDPZIw")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Contains Authorised amount details.
    /// </summary>
    [IsoId("_fKVahPcXEeiW-auGnDPZIw")]
    [DisplayName("Authorised Amount")]
    [IsoXmlTag("AuthrsdAmt")]
    public AuthorisedAmount1? AuthorisedAmount { get; init; }

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_zIKFxvcVEeiW-auGnDPZIw")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Loyalty programme details.
    /// </summary>
    [IsoId("_zIKFx_cVEeiW-auGnDPZIw")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; }

    /// <summary>
    /// Additional user-defined data pertaining to the lodging.
    /// </summary>
    [IsoId("_zIKFyPcVEeiW-auGnDPZIw")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
