// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Invoice related to a vehicle rental service.
/// </summary>
[IsoId("_cYeOxvTZEeife6veM7daYw")]
[DisplayName("Vehicle Rental Invoice")]
public partial record VehicleRentalInvoice1
{
    #nullable enable
    
    /// <summary>
    /// Indicates that the cardholder failed to pick up the vehicle and was therefore charged a no-show fee; vehicle was not actually rented. 
    /// </summary>
    [IsoId("_cYeO1fTZEeife6veM7daYw")]
    [DisplayName("No Show Indicator")]
    [IsoXmlTag("NoShowInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? NoShowIndicator { get; init; } 
    
    /// <summary>
    /// Indicates that an adjustment was made to a vehicle rental charge (for example, additional charges added). 
    /// </summary>
    [IsoId("_cYeO2PTZEeife6veM7daYw")]
    [DisplayName("Adjusted Indicator")]
    [IsoXmlTag("AdjstdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AdjustedIndicator { get; init; } 
    
    /// <summary>
    /// Location to which vehicle was returned.
    /// </summary>
    [IsoId("_cYeO0_TZEeife6veM7daYw")]
    [DisplayName("Return Location")]
    [IsoXmlTag("RtrLctn")]
    public Address1? ReturnLocation { get; init; } 
    
    /// <summary>
    /// Date the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup date.
    /// </summary>
    [IsoId("_cYeOyPTZEeife6veM7daYw")]
    [DisplayName("Check Out Date")]
    [IsoXmlTag("ChckOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CheckOutDate { get; init; } 
    
    /// <summary>
    /// Time the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup time.
    /// </summary>
    [IsoId("_cYeOzPTZEeife6veM7daYw")]
    [DisplayName("Check Out Time")]
    [IsoXmlTag("ChckOutTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? CheckOutTime { get; init; } 
    
    /// <summary>
    /// Date when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_cYeO0vTZEeife6veM7daYw")]
    [DisplayName("Check In Date")]
    [IsoXmlTag("ChckInDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CheckInDate { get; init; } 
    
    /// <summary>
    /// Time when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_cYeOx_TZEeife6veM7daYw")]
    [DisplayName("Check In Time")]
    [IsoXmlTag("ChckInTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? CheckInTime { get; init; } 
    
    /// <summary>
    /// Duration of rental in days.
    /// </summary>
    [IsoId("_cYeO2fTZEeife6veM7daYw")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? Duration { get; init; } 
    
    /// <summary>
    /// Contains the details of the vehicle class invoiced to the renter regardless of the class of vehicle actually provided. 
    /// </summary>
    [IsoId("_cYeO1vTZEeife6veM7daYw")]
    [DisplayName("Vehicle Class Invoiced")]
    [IsoXmlTag("VhclClssInvcd")]
    public Vehicle4? VehicleClassInvoiced { get; init; } 
    
    /// <summary>
    /// Contains the details of the vehicle class of the vehicle actually provided to the renter at the time of vehicle pick-up. This may be an upgrade class of vehicle, above that invoiced to the renter. 
    /// </summary>
    [IsoId("_cYeO1PTZEeife6veM7daYw")]
    [DisplayName("Vehicle Class Provided")]
    [IsoXmlTag("VhclClssPrvdd")]
    public Vehicle4? VehicleClassProvided { get; init; } 
    
    /// <summary>
    /// Distance travelled during vehicle rental.
    /// </summary>
    [IsoId("_cYeOz_TZEeife6veM7daYw")]
    [DisplayName("Travel Distance")]
    [IsoXmlTag("TrvlDstnc")]
    public Distance1? TravelDistance { get; init; } 
    
    /// <summary>
    /// Vehicle rental charge.
    /// </summary>
    [IsoId("_cYeOzvTZEeife6veM7daYw")]
    [DisplayName("Rental Charge")]
    [IsoXmlTag("RntlChrg")]
    public RentalRate1? RentalCharge { get; init; } 
    
    /// <summary>
    /// Provides the identifier assigned by the card acceptor that best categorizes the items being purchased in a standardized commodity group.
    /// </summary>
    [IsoId("_v-ZlEfTcEeife6veM7daYw")]
    [DisplayName("Summary Commodity Identification")]
    [IsoXmlTag("SummryCmmdtyId")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? SummaryCommodityIdentification { get; init; } 
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_cYeO0fTZEeife6veM7daYw")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    
    /// <summary>
    /// Contains the details of additional amount for a specific vehicle rental service type. 
    /// </summary>
    [IsoId("_cYeOyfTZEeife6veM7daYw")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public Amount9? AdditionalAmount { get; init; } 
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_cYeO2vTZEeife6veM7daYw")]
    [DisplayName("Tax")]
    [IsoXmlTag("Tax")]
    public Tax33? Tax { get; init; } 
    
    
    #nullable disable
    
}
