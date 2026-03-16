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
[IsoId("_JJ2zkcWmEeuhguwJmlgagQ")]
[DisplayName("Lodging Summary")]
public record LodgingSummary2
{
    /// <summary>
    /// Contains the lodging company&apos;s invoice or billing ID reference number, referred to as a folio number.
    /// </summary>
    [IsoId("_JONIEcWmEeuhguwJmlgagQ")]
    [DisplayName("Folio Number")]
    [IsoXmlTag("FolioNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? FolioNumber { get; init; }

    /// <summary>
    /// Details of the lodging property.
    /// </summary>
    [IsoId("_JONIE8WmEeuhguwJmlgagQ")]
    [DisplayName("Property")]
    [IsoXmlTag("Prprty")]
    public LodgingProperty2? Property { get; init; }

    /// <summary>
    /// Contains customer details.
    /// </summary>
    [IsoId("_JONIFcWmEeuhguwJmlgagQ")]
    [DisplayName("Customer")]
    [IsoXmlTag("Cstmr")]
    public Customer8? Customer { get; init; }

    /// <summary>
    /// Number of rooms within the reservation.
    /// </summary>
    [IsoId("_JONIF8WmEeuhguwJmlgagQ")]
    [DisplayName("Number Of Rooms")]
    [IsoXmlTag("NbOfRooms")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? NumberOfRooms { get; init; }

    /// <summary>
    /// Contains the room details.
    /// </summary>
    [IsoId("_JONIGcWmEeuhguwJmlgagQ")]
    [DisplayName("Room")]
    [IsoXmlTag("Room")]
    public ValueList<LodgingRoom1> Room { get; init; } = [];

    /// <summary>
    /// Duration of stay in days.
    /// </summary>
    [IsoId("_JONIG8WmEeuhguwJmlgagQ")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Lodging transaction details.
    /// </summary>
    [IsoId("_JONIHcWmEeuhguwJmlgagQ")]
    [DisplayName("Arrival")]
    [IsoXmlTag("Arrvl")]
    public DepartureOrArrival2? Arrival { get; init; }

    /// <summary>
    /// Contains departure details.
    /// </summary>
    [IsoId("_JONIH8WmEeuhguwJmlgagQ")]
    [DisplayName("Departure")]
    [IsoXmlTag("Dprture")]
    public DepartureOrArrival1? Departure { get; init; }

    /// <summary>
    /// Indicates that the cardholder failed to arrive at the property and was therefore charged a no-show fee; property was not actually rented.
    /// </summary>
    [IsoId("_JONIIcWmEeuhguwJmlgagQ")]
    [DisplayName("No Show Indicator")]
    [IsoXmlTag("NoShowInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NoShowIndicator { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_JONII8WmEeuhguwJmlgagQ")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Amount of insurance.
    /// </summary>
    [IsoId("_JONIJcWmEeuhguwJmlgagQ")]
    [DisplayName("Insurance Amount")]
    [IsoXmlTag("InsrncAmt")]
    public ImpliedCurrencyAndAmount? InsuranceAmount { get; init; }

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_JONIJ8WmEeuhguwJmlgagQ")]
    [DisplayName("Total Tax")]
    [IsoXmlTag("TtlTax")]
    public ValueList<Tax39> TotalTax { get; init; } = [];

    /// <summary>
    /// Contains the total amount of lodging expenses.
    /// </summary>
    [IsoId("_JONIKcWmEeuhguwJmlgagQ")]
    [DisplayName("Total Amount")]
    [IsoXmlTag("TtlAmt")]
    public ImpliedCurrencyAndAmount? TotalAmount { get; init; }

    /// <summary>
    /// Contains Authorised amount details.
    /// </summary>
    [IsoId("_JONIK8WmEeuhguwJmlgagQ")]
    [DisplayName("Authorised Amount")]
    [IsoXmlTag("AuthrsdAmt")]
    public ValueList<AuthorisedAmount1> AuthorisedAmount { get; init; } = [];

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_JONILcWmEeuhguwJmlgagQ")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Loyalty programme details.
    /// </summary>
    [IsoId("_JONIL8WmEeuhguwJmlgagQ")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public ValueList<LoyaltyProgramme2> LoyaltyProgramme { get; init; } = [];

    /// <summary>
    /// Additional user-defined data pertaining to the lodging.
    /// </summary>
    [IsoId("_JONIMcWmEeuhguwJmlgagQ")]
    [DisplayName("Additional Data")]
    [IsoXmlTag("AddtlData")]
    [IsoSimpleType(IsoSimpleType.Max350Text)]
    [StringLength(maximumLength: 350, MinimumLength = 1)]
    public IsoMax350Text? AdditionalData { get; init; }
}
