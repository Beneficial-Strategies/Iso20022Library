// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Company in charge of a vehicle rental service.
/// </summary>
[IsoId("_mU3xscWlEeuhguwJmlgagQ")]
[DisplayName("Vehicle Rental Company")]
public partial record VehicleRentalCompany2
{
    #nullable enable
    
    /// <summary>
    /// Name of the vehicle rental company.
    /// </summary>
    [IsoId("_mZTlwcWlEeuhguwJmlgagQ")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? Name { get; init; } 
    
    /// <summary>
    /// Identification of the vehicle rental company.
    /// </summary>
    [IsoId("_mZTlw8WlEeuhguwJmlgagQ")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public PartyIdentification258? Identification { get; init; } 
    
    /// <summary>
    /// Address of the vehicle rental company.
    /// </summary>
    [IsoId("_mZTlxcWlEeuhguwJmlgagQ")]
    [DisplayName("Address")]
    [IsoXmlTag("Adr")]
    public Address2? Address { get; init; } 
    
    /// <summary>
    /// Contact details at vehicle rental company location.
    /// </summary>
    [IsoId("_mZTlx8WlEeuhguwJmlgagQ")]
    [DisplayName("Contact")]
    [IsoXmlTag("Ctct")]
    public Contact3? Contact { get; init; } 
    
    /// <summary>
    /// Country of the vehicle rental company.
    /// ISO 3166
    /// </summary>
    [IsoId("_mZTlycWlEeuhguwJmlgagQ")]
    [DisplayName("Country")]
    [IsoXmlTag("Ctry")]
    public ISOMax3ACountryCode? Country { get; init; } 
    
    /// <summary>
    /// Type of vehicle rental activity.
    /// </summary>
    [IsoId("_mZTly8WlEeuhguwJmlgagQ")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public CarRentalActivity1Code? Type { get; init; } 
    
    /// <summary>
    /// Other type of vehicle rental activity. 
    /// </summary>
    [IsoId("_mZTlzcWlEeuhguwJmlgagQ")]
    [DisplayName("Other Type")]
    [IsoXmlTag("OthrTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? OtherType { get; init; } 
    
    
    #nullable disable
    
}
