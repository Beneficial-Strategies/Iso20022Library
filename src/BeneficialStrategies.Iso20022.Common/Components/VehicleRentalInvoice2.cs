// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Invoice related to a vehicle rental service.
/// </summary>
[IsoId("_lhcpkayfEeuupt0UCH5uiw")]
[DisplayName("Vehicle Rental Invoice")]
public record VehicleRentalInvoice2
{
    /// <summary>
    /// Indicates that the cardholder failed to pick up the vehicle and was therefore charged a no-show fee; vehicle was not actually rented.
    /// </summary>
    [IsoId("_llnX4ayfEeuupt0UCH5uiw")]
    [DisplayName("No Show Indicator")]
    [IsoXmlTag("NoShowInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NoShowIndicator { get; init; }

    /// <summary>
    /// Indicates that an adjustment was made to a vehicle rental charge (for example, additional charges added).
    /// </summary>
    [IsoId("_llnX46yfEeuupt0UCH5uiw")]
    [DisplayName("Adjusted Indicator")]
    [IsoXmlTag("AdjstdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AdjustedIndicator { get; init; }

    /// <summary>
    /// Location to which vehicle was returned.
    /// </summary>
    [IsoId("_llnX5ayfEeuupt0UCH5uiw")]
    [DisplayName("Return Location")]
    [IsoXmlTag("RtrLctn")]
    public Address2? ReturnLocation { get; init; }

    /// <summary>
    /// Date the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup date.
    /// </summary>
    [IsoId("_llnX56yfEeuupt0UCH5uiw")]
    [DisplayName("Check Out Date")]
    [IsoXmlTag("ChckOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CheckOutDate { get; init; }

    /// <summary>
    /// Time the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup time.
    /// </summary>
    [IsoId("_llnX6ayfEeuupt0UCH5uiw")]
    [DisplayName("Check Out Time")]
    [IsoXmlTag("ChckOutTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? CheckOutTime { get; init; }

    /// <summary>
    /// Date when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_llnX66yfEeuupt0UCH5uiw")]
    [DisplayName("Check In Date")]
    [IsoXmlTag("ChckInDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CheckInDate { get; init; }

    /// <summary>
    /// Time when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_llnX7ayfEeuupt0UCH5uiw")]
    [DisplayName("Check In Time")]
    [IsoXmlTag("ChckInTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? CheckInTime { get; init; }

    /// <summary>
    /// Duration of rental in days.
    /// </summary>
    [IsoId("_llnX76yfEeuupt0UCH5uiw")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? Duration { get; init; }

    /// <summary>
    /// Contains the details of the vehicle class invoiced to the renter regardless of the class of vehicle actually provided.
    /// </summary>
    [IsoId("_llnX8ayfEeuupt0UCH5uiw")]
    [DisplayName("Vehicle Class Invoiced")]
    [IsoXmlTag("VhclClssInvcd")]
    public Vehicle4? VehicleClassInvoiced { get; init; }

    /// <summary>
    /// Contains the details of the vehicle class of the vehicle actually provided to the renter at the time of vehicle pick-up. This may be an upgrade class of vehicle, above that invoiced to the renter.
    /// </summary>
    [IsoId("_llnX86yfEeuupt0UCH5uiw")]
    [DisplayName("Vehicle Class Provided")]
    [IsoXmlTag("VhclClssPrvdd")]
    public Vehicle4? VehicleClassProvided { get; init; }

    /// <summary>
    /// Distance travelled during vehicle rental.
    /// </summary>
    [IsoId("_llnX9ayfEeuupt0UCH5uiw")]
    [DisplayName("Travel Distance")]
    [IsoXmlTag("TrvlDstnc")]
    public Distance1? TravelDistance { get; init; }

    /// <summary>
    /// Vehicle rental charge.
    /// </summary>
    [IsoId("_llnX96yfEeuupt0UCH5uiw")]
    [DisplayName("Rental Charge")]
    [IsoXmlTag("RntlChrg")]
    public ValueList<RentalRate1> RentalCharge { get; init; } = [];

    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_llnX-ayfEeuupt0UCH5uiw")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; }

    /// <summary>
    /// Indicates whether or not insurance was purchased.
    /// </summary>
    [IsoId("_llnX-6yfEeuupt0UCH5uiw")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; }

    /// <summary>
    /// Contains the details of additional amount for a specific vehicle rental service type.
    /// </summary>
    [IsoId("_llnX_ayfEeuupt0UCH5uiw")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<Amount18> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Taxes related to the products or services.
    /// </summary>
    [IsoId("_llnX_6yfEeuupt0UCH5uiw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public ValueList<Tax39> Tax { get; init; } = [];
}
