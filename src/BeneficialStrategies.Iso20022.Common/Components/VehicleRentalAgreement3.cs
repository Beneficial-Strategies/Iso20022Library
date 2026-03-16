// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vehicle Rental Agreement3.
/// </summary>
[IsoId("_xUZv8XTjEe6h-4AZRg9sVg")]
[DisplayName("Vehicle Rental Agreement3")]
public partial record VehicleRentalAgreement3
{
    #nullable enable

    /// <summary>
    /// Additional Amount.
    /// </summary>
    [DisplayName("Additional Amount")]
    [IsoXmlTag("AddtlAmt")]
    public ValueList<Amount21> AdditionalAmount { get; init; } = [];

    /// <summary>
    /// Adjusted.
    /// </summary>
    [DisplayName("Adjusted")]
    [IsoXmlTag("Adjstd")]
    public IsoTrueFalseIndicator? Adjusted { get; init; } 

    /// <summary>
    /// Check In Date.
    /// </summary>
    [DisplayName("Check In Date")]
    [IsoXmlTag("ChckInDt")]
    public IsoISODate? CheckInDate { get; init; } 

    /// <summary>
    /// Check In Time.
    /// </summary>
    [DisplayName("Check In Time")]
    [IsoXmlTag("ChckInTm")]
    public IsoISOTime? CheckInTime { get; init; } 

    /// <summary>
    /// Check Out Date.
    /// </summary>
    [DisplayName("Check Out Date")]
    [IsoXmlTag("ChckOutDt")]
    public IsoISODate? CheckOutDate { get; init; } 

    /// <summary>
    /// Check Out Time.
    /// </summary>
    [DisplayName("Check Out Time")]
    [IsoXmlTag("ChckOutTm")]
    public IsoISOTime? CheckOutTime { get; init; } 

    /// <summary>
    /// Class.
    /// </summary>
    [DisplayName("Class")]
    [IsoXmlTag("Clss")]
    public IsoMax35Text? Class { get; init; } 

    /// <summary>
    /// Discount Programme.
    /// </summary>
    [DisplayName("Discount Programme")]
    [IsoXmlTag("DscntPrgrmm")]
    public ValueList<Discount3> DiscountProgramme { get; init; } = [];

    /// <summary>
    /// Duration.
    /// </summary>
    [DisplayName("Duration")]
    [IsoXmlTag("Drtn")]
    public IsoMax4NumericText? Duration { get; init; } 

    /// <summary>
    /// Estimated Tax.
    /// </summary>
    [DisplayName("Estimated Tax")]
    [IsoXmlTag("EstmtdTax")]
    public ValueList<Tax41> EstimatedTax { get; init; } = [];

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
    public ValueList<LoyaltyProgramme5> LoyaltyProgramme { get; init; } = [];

    /// <summary>
    /// Make.
    /// </summary>
    [DisplayName("Make")]
    [IsoXmlTag("Make")]
    public IsoMax35NumericText? Make { get; init; } 

    /// <summary>
    /// Model.
    /// </summary>
    [DisplayName("Model")]
    [IsoXmlTag("Mdl")]
    public IsoMax35NumericText? Model { get; init; } 

    /// <summary>
    /// Number.
    /// </summary>
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public IsoMax35Text? Number { get; init; } 

    /// <summary>
    /// Pickup Location.
    /// </summary>
    [DisplayName("Pickup Location")]
    [IsoXmlTag("PckpLctn")]
    public ValueList<Address2> PickupLocation { get; init; } = [];

    /// <summary>
    /// Registration Number.
    /// </summary>
    [DisplayName("Registration Number")]
    [IsoXmlTag("RegnNb")]
    public IsoMax35Text? RegistrationNumber { get; init; } 

    /// <summary>
    /// Rental Details.
    /// </summary>
    [DisplayName("Rental Details")]
    [IsoXmlTag("RntlDtls")]
    public RentalDetails3? RentalDetails { get; init; } 

    /// <summary>
    /// Rental Location.
    /// </summary>
    [DisplayName("Rental Location")]
    [IsoXmlTag("RntlLctn")]
    public Address2? RentalLocation { get; init; } 

    /// <summary>
    /// Rental Rate.
    /// </summary>
    [DisplayName("Rental Rate")]
    [IsoXmlTag("RntlRate")]
    public ValueList<RentalRate2> RentalRate { get; init; } = [];

    /// <summary>
    /// Return Location.
    /// </summary>
    [DisplayName("Return Location")]
    [IsoXmlTag("RtrLctn")]
    public Address2? ReturnLocation { get; init; } 

    /// <summary>
    /// Travel Distance.
    /// </summary>
    [DisplayName("Travel Distance")]
    [IsoXmlTag("TrvlDstnc")]
    public Distance1? TravelDistance { get; init; } 

    
    #nullable disable
    
}
