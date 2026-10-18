// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Vehicle Rental Agreement3.
/// </summary>
[IsoId("_xUZv8XTjEe6h-4AZRg9sVg")]
[DisplayName("Vehicle Rental Agreement3")]
public record VehicleRentalAgreement3
{
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
    public TrueFalseIndicator? Adjusted { get; init; }

    /// <summary>
    /// Check In Date.
    /// </summary>
    [DisplayName("Check In Date")]
    [IsoXmlTag("ChckInDt")]
    public ISODate? CheckInDate { get; init; }

    /// <summary>
    /// Check In Time.
    /// </summary>
    [DisplayName("Check In Time")]
    [IsoXmlTag("ChckInTm")]
    public ISOTime? CheckInTime { get; init; }

    /// <summary>
    /// Check Out Date.
    /// </summary>
    [DisplayName("Check Out Date")]
    [IsoXmlTag("ChckOutDt")]
    public ISODate? CheckOutDate { get; init; }

    /// <summary>
    /// Check Out Time.
    /// </summary>
    [DisplayName("Check Out Time")]
    [IsoXmlTag("ChckOutTm")]
    public ISOTime? CheckOutTime { get; init; }

    /// <summary>
    /// Class.
    /// </summary>
    [DisplayName("Class")]
    [IsoXmlTag("Clss")]
    public Max35Text? Class { get; init; }

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
    public Max4NumericText? Duration { get; init; }

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
    public TrueFalseIndicator? Insurance { get; init; }

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
    public Max35NumericText? Make { get; init; }

    /// <summary>
    /// Model.
    /// </summary>
    [DisplayName("Model")]
    [IsoXmlTag("Mdl")]
    public Max35NumericText? Model { get; init; }

    /// <summary>
    /// Number.
    /// </summary>
    [DisplayName("Number")]
    [IsoXmlTag("Nb")]
    public Max35Text? Number { get; init; }

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
    public Max35Text? RegistrationNumber { get; init; }

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
}
