// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer renting a vehicle.
/// </summary>
[IsoId("_fx0Cj_SsEeife6veM7daYw")]
[DisplayName("Vehicle Rental Customer")]
public record VehicleRentalCustomer1
{
    /// <summary>
    /// Name of the vehicle rental customer.
    /// </summary>
    [IsoId("_fx0CkfSsEeife6veM7daYw")]
    [DisplayName("Renter Name")]
    [IsoXmlTag("RntrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public required IsoMax70Text RenterName { get; init; }

    /// <summary>
    /// Corporate name of the vehicle rental customer.
    /// </summary>
    [IsoId("_fx0CmPSsEeife6veM7daYw")]
    [DisplayName("Corporate Name")]
    [IsoXmlTag("CorpNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70, MinimumLength = 1)]
    public IsoMax70Text? CorporateName { get; init; }

    /// <summary>
    /// Corporate identifier of the vehicle rental customer.
    /// </summary>
    [IsoId("_fx0pkPSsEeife6veM7daYw")]
    [DisplayName("Corporate Identifier")]
    [IsoXmlTag("CorpIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35, MinimumLength = 1)]
    public required IsoMax35Text CorporateIdentifier { get; init; }

    /// <summary>
    /// Party assigning an identification to a vehicle rental customer.
    /// </summary>
    [IsoId("_fx0Cl_SsEeife6veM7daYw")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public CustomerAssigner1Code? Assigner { get; init; }

    /// <summary>
    /// Vehicle rental driver.
    /// </summary>
    [IsoId("_fx0ClPSsEeife6veM7daYw")]
    [DisplayName("Primary Driver")]
    [IsoXmlTag("PmryDrvr")]
    public ValueList<DriverInParty1> PrimaryDriver { get; init; } = [];

    /// <summary>
    /// Type of identification of the additional vehicle rental customer.
    /// </summary>
    [IsoId("_fx0CmfSsEeife6veM7daYw")]
    [DisplayName("Additional Driver")]
    [IsoXmlTag("AddtlDrvr")]
    public ValueList<DriverInParty1> AdditionalDriver { get; init; } = [];

    /// <summary>
    /// Loyalty programme details.
    /// </summary>
    [IsoId("_sLqMsfSvEeife6veM7daYw")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; }
}
