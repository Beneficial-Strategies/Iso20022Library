// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Agreement (contract) related to a vehicle rental service.
/// </summary>
[IsoId("_R4nhWvSwEeife6veM7daYw")]
[DisplayName("Vehicle Rental Agreement")]
public partial record VehicleRentalAgreement1
{
    #nullable enable
    
    /// <summary>
    /// Contains the original vehicle rental agreement, invoice or contract number.
    /// </summary>
    [IsoId("_R4nhYfSwEeife6veM7daYw")]
    [DisplayName("Agreement Number")]
    [IsoXmlTag("AgrmtNb")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? AgreementNumber { get; init; } 
    
    /// <summary>
    /// Indicates that an adjustment was made to a vehicle rental charge (for example, additional charges added). 
    /// </summary>
    [IsoId("_R4nhXvSwEeife6veM7daYw")]
    [DisplayName("Adjusted Indicator")]
    [IsoXmlTag("AdjstdInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? AdjustedIndicator { get; init; } 
    
    /// <summary>
    /// Contains the vehicle rental location. 
    /// </summary>
    [IsoId("_R4nhW_SwEeife6veM7daYw")]
    [DisplayName("Rental Location")]
    [IsoXmlTag("RntlLctn")]
    public Address1? RentalLocation { get; init; } 
    
    /// <summary>
    /// Used when different than rental location
    /// </summary>
    [IsoId("_R4nhZ_SwEeife6veM7daYw")]
    [DisplayName("Pickup Location")]
    [IsoXmlTag("PckpLctn")]
    public Address1? PickupLocation { get; init; } 
    
    /// <summary>
    /// Date the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup date.
    /// </summary>
    [IsoId("_R4nhYPSwEeife6veM7daYw")]
    [DisplayName("Check Out Date")]
    [IsoXmlTag("ChckOutDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CheckOutDate { get; init; } 
    
    /// <summary>
    /// Time the vehicle was picked-up by the customer.  In the case of a no-show transaction or a prepaid transaction, this contains the scheduled pickup time.
    /// </summary>
    [IsoId("_R4nhZvSwEeife6veM7daYw")]
    [DisplayName("Check Out Time")]
    [IsoXmlTag("ChckOutTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? CheckOutTime { get; init; } 
    
    /// <summary>
    /// Location to which vehicle was returned.
    /// </summary>
    [IsoId("_R4nhbfSwEeife6veM7daYw")]
    [DisplayName("Return Location")]
    [IsoXmlTag("RtrLctn")]
    public Address1? ReturnLocation { get; init; } 
    
    /// <summary>
    /// Date when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_R4nhX_SwEeife6veM7daYw")]
    [DisplayName("Check In Date")]
    [IsoXmlTag("ChckInDt")]
    [IsoSimpleType(IsoSimpleType.ISODate)]
    public IsoISODate? CheckInDate { get; init; } 
    
    /// <summary>
    /// Time when the vehicle was returned to the rental agency.
    /// </summary>
    [IsoId("_R4nhbPSwEeife6veM7daYw")]
    [DisplayName("Check In Time")]
    [IsoXmlTag("ChckInTm")]
    [IsoSimpleType(IsoSimpleType.ISOTime)]
    public IsoISOTime? CheckInTime { get; init; } 
    
    /// <summary>
    /// Duration of rental in days.
    /// </summary>
    [IsoId("_R4nhaPSwEeife6veM7daYw")]
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    [IsoSimpleType(IsoSimpleType.Max4NumericText)]
    public IsoMax4NumericText? Duration { get; init; } 
    
    /// <summary>
    /// Contains the details of the vehicle classification.
    /// </summary>
    [IsoId("_F5fqkPS1Eeife6veM7daYw")]
    [DisplayName("Vehicle Class Details")]
    [IsoXmlTag("VhclClssDtls")]
    public Vehicle4? VehicleClassDetails { get; init; } 
    
    /// <summary>
    /// Distance travelled during vehicle rental.
    /// </summary>
    [IsoId("_R4nhZfSwEeife6veM7daYw")]
    [DisplayName("Travel Distance")]
    [IsoXmlTag("TrvlDstnc")]
    public Distance1? TravelDistance { get; init; } 
    
    /// <summary>
    /// Vehicle rental rate.
    /// </summary>
    [IsoId("_R4nha_SwEeife6veM7daYw")]
    [DisplayName("Rental Rate")]
    [IsoXmlTag("RntlRate")]
    public RentalRate1? RentalRate { get; init; } 
    
    /// <summary>
    /// Vehicle rental details.
    /// </summary>
    [IsoId("_R4nhcfSwEeife6veM7daYw")]
    [DisplayName("Rental Details")]
    [IsoXmlTag("RntlDtls")]
    public RentalDetails1? RentalDetails { get; init; } 
    
    /// <summary>
    /// Registration number of vehicle.
    /// </summary>
    [IsoId("_R4nhbvSwEeife6veM7daYw")]
    [DisplayName("Vehicle Registration Number")]
    [IsoXmlTag("VhclRegnNb")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? VehicleRegistrationNumber { get; init; } 
    
    /// <summary>
    /// Indicates whether or not insurance was purchased. 
    /// </summary>
    [IsoId("_--XHofS4Eeife6veM7daYw")]
    [DisplayName("Insurance Indicator")]
    [IsoXmlTag("InsrncInd")]
    [IsoSimpleType(IsoSimpleType.TrueFalseIndicator)]
    public IsoTrueFalseIndicator? InsuranceIndicator { get; init; } 
    
    /// <summary>
    /// Contains the details of additional amount for a specific vehicle rental service type. 
    /// </summary>
    [IsoId("_R4nhb_SwEeife6veM7daYw")]
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public Amount9? AdditionalAmount { get; init; } 
    
    /// <summary>
    /// Taxes related to the products or services. 
    /// </summary>
    [IsoId("_R4nhXPSwEeife6veM7daYw")]
    [DisplayName("Estimated Tax")]
    [IsoXmlTag("EstmtdTax")]
    public Tax33? EstimatedTax { get; init; } 
    
    /// <summary>
    /// Discount applied to the vehicle rental.
    /// </summary>
    [IsoId("_R4nhYvSwEeife6veM7daYw")]
    [DisplayName("Discount Programme")]
    [IsoXmlTag("DscntPrgrmm")]
    public Discount3? DiscountProgramme { get; init; } 
    
    /// <summary>
    /// Loyalty programme details.
    /// </summary>
    [IsoId("_R4nhXfSwEeife6veM7daYw")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme1? LoyaltyProgramme { get; init; } 
    
    
    #nullable disable
    
}
