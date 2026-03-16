// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Agreement (contract) related to a vehicle rental service.
/// </summary>
[IsoId("_wcJ5EayeEeuupt0UCH5uiw")]
[DisplayName("Vehicle Rental Agreement")]
public record VehicleRentalAgreement2
{
    /// <summary>
    /// Contains the original vehicle rental agreement, invoice or contract number.
    /// </summary>
    [IsoId("_wgUnYayeEeuupt0UCH5uiw")]
    [DisplayName("Agreement Number")]
    [IsoXmlTag("AgrmtNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? AgreementNumber { get; init; }

    /// <summary>
    /// Indicates that an adjustment was made to a vehicle rental charge (for example, additional charges added).
    /// </summary>
    [IsoId("_wgUnY6yeEeuupt0UCH5uiw")]
    [DisplayName("Adjusted Indicator")]
    [IsoXmlTag("AdjstdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AdjustedIndicator { get; init; }

    /// <summary>
    /// Contains the vehicle rental location.
    /// </summary>
    [IsoId("_wgUnZayeEeuupt0UCH5uiw")]
    [DisplayName("Rental Location")]
    [IsoXmlTag("RntlLctn")]
    public Address2? RentalLocation { get; init; }

    /// <summary>
    /// Used when different than rental location
    /// </summary>
    [IsoId("_wgUnZ6yeEeuupt0UCH5uiw")]
    [DisplayName("Pickup Location")]
    [IsoXmlTag("PckpLctn")]
    public Address2? PickupLocation { get; init; }

    /// <summary>
    /// Date the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup date.
    /// </summary>
    [IsoId("_wgUnaayeEeuupt0UCH5uiw")]
    [DisplayName("Check Out Date")]
    [IsoXmlTag("ChckOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CheckOutDate { get; init; }

    /// <summary>
    /// Time the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup time.
    /// </summary>
    [IsoId("_wgUna6yeEeuupt0UCH5uiw")]
    [DisplayName("Check Out Time")]
    [IsoXmlTag("ChckOutTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? CheckOutTime { get; init; }

    /// <summary>
    /// Location to which vehicle was returned.
    /// </summary>
    [IsoId("_wgUnbayeEeuupt0UCH5uiw")]
    [DisplayName("Return Location")]
    [IsoXmlTag("RtrLctn")]
    public Address2? ReturnLocation { get; init; }

    /// <summary>
    /// Date when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_wgUnb6yeEeuupt0UCH5uiw")]
    [DisplayName("Check In Date")]
    [IsoXmlTag("ChckInDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CheckInDate { get; init; }

    /// <summary>
    /// Time when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_wgUncayeEeuupt0UCH5uiw")]
    [DisplayName("Check In Time")]
    [IsoXmlTag("ChckInTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? CheckInTime { get; init; }

    /// <summary>
    /// Duration of rental in days.
    /// </summary>
    [IsoId("_wgUnc6yeEeuupt0UCH5uiw")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Contains the details of the vehicle classification.
    /// </summary>
    [IsoId("_wgUndayeEeuupt0UCH5uiw")]
    [DisplayName("Vehicle Class Details")]
    [IsoXmlTag("VhclClssDtls")]
    public Vehicle4? VehicleClassDetails { get; init; }

    /// <summary>
    /// Distance travelled during vehicle rental.
    /// </summary>
    [IsoId("_wgUnd6yeEeuupt0UCH5uiw")]
    [DisplayName("Travel Distance")]
    [IsoXmlTag("TrvlDstnc")]
    public Distance1? TravelDistance { get; init; }

    /// <summary>
    /// Vehicle rental rate.
    /// </summary>
    [IsoId("_wgUneayeEeuupt0UCH5uiw")]
    [DisplayName("Rental Rate")]
    [IsoXmlTag("RntlRate")]
    public RentalRate1? RentalRate { get; init; }

    /// <summary>
    /// Vehicle rental details.
    /// </summary>
    [IsoId("_wgUne6yeEeuupt0UCH5uiw")]
    [DisplayName("Rental Details")]
    [IsoXmlTag("RntlDtls")]
    public RentalDetails2? RentalDetails { get; init; }

    /// <summary>
    /// Registration number of vehicle.
    /// </summary>
    [IsoId("_wgUnfayeEeuupt0UCH5uiw")]
    [DisplayName("Vehicle Registration Number")]
    [IsoXmlTag("VhclRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? VehicleRegistrationNumber { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_wgUnf6yeEeuupt0UCH5uiw")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Contains the details of additional amount for a specific vehicle rental service type.
    /// </summary>
    [IsoId("_wgUngayeEeuupt0UCH5uiw")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public Amount18? AdditionalAmount { get; init; }

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_wgUng6yeEeuupt0UCH5uiw")]
    [DisplayName("Estimated Tax")]
    [IsoXmlTag("EstmtdTax")]
    public Tax39? EstimatedTax { get; init; }

    /// <summary>
    /// Discount applied to the vehicle rental.
    /// </summary>
    [IsoId("_wgUnhayeEeuupt0UCH5uiw")]
    [DisplayName("Discount Programme")]
    [IsoXmlTag("DscntPrgrmm")]
    public Discount3? DiscountProgramme { get; init; }

    /// <summary>
    /// Loyalty programme details.
    /// </summary>
    [IsoId("_wgUnh6yeEeuupt0UCH5uiw")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme3? LoyaltyProgramme { get; init; }
}
