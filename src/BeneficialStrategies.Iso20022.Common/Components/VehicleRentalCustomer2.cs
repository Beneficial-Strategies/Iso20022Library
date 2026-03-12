// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Customer renting a vehicle.
/// </summary>
[IsoId("_hRHmIcW0EeuhguwJmlgagQ")]
[DisplayName("Vehicle Rental Customer")]
public partial record VehicleRentalCustomer2
{
    #nullable enable
    
    /// <summary>
    /// Name of the vehicle rental customer.
    /// </summary>
    [IsoId("_hVxcocW0EeuhguwJmlgagQ")]
    [DisplayName("Renter Name")]
    [IsoXmlTag("RntrNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text RenterName { get; init; } 
    
    /// <summary>
    /// Corporate name of the vehicle rental customer.
    /// </summary>
    [IsoId("_hVxco8W0EeuhguwJmlgagQ")]
    [DisplayName("Corporate Name")]
    [IsoXmlTag("CorpNm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? CorporateName { get; init; } 
    
    /// <summary>
    /// Corporate identifier of the vehicle rental customer.
    /// </summary>
    [IsoId("_hVxcpcW0EeuhguwJmlgagQ")]
    [DisplayName("Corporate Identifier")]
    [IsoXmlTag("CorpIdr")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text CorporateIdentifier { get; init; } 
    
    /// <summary>
    /// Party assigning an identification to a vehicle rental customer.
    /// </summary>
    [IsoId("_hVxcp8W0EeuhguwJmlgagQ")]
    [DisplayName("Assigner")]
    [IsoXmlTag("Assgnr")]
    public CustomerAssigner1Code? Assigner { get; init; } 
    
    /// <summary>
    /// Vehicle rental driver.
    /// </summary>
    [IsoId("_hVxcqcW0EeuhguwJmlgagQ")]
    [DisplayName("Primary Driver")]
    [IsoXmlTag("PmryDrvr")]
    public DriverInParty2? PrimaryDriver { get; init; } 
    
    /// <summary>
    /// Type of identification of the additional vehicle rental customer.
    /// </summary>
    [IsoId("_hVxcq8W0EeuhguwJmlgagQ")]
    [DisplayName("Additional Driver")]
    [IsoXmlTag("AddtlDrvr")]
    public DriverInParty2? AdditionalDriver { get; init; } 
    
    /// <summary>
    /// Loyalty programme details. 
    /// </summary>
    [IsoId("_hVxcrcW0EeuhguwJmlgagQ")]
    [DisplayName("Loyalty Programme")]
    [IsoXmlTag("LltyPrgrmm")]
    public LoyaltyProgramme2? LoyaltyProgramme { get; init; } 
    
    
    #nullable disable
    
}
