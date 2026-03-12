// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies the details of the contact person.
/// </summary>
[IsoId("__RflYS1AEeqVb9PEK4pNyA")]
[DisplayName("Contact")]
public partial record Contact9
{
    #nullable enable
    
    /// <summary>
    /// Name of the party, such as a person or a team, responsible for the report.
    /// </summary>
    [IsoId("__TBPYS1AEeqVb9PEK4pNyA")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text Name { get; init; } 
    
    /// <summary>
    /// Phone number of the person responsible for the report.
    /// </summary>
    [IsoId("__TBPYy1AEeqVb9PEK4pNyA")]
    [DisplayName("Phone Number")]
    [IsoXmlTag("PhneNb")]
    [IsoSimpleType(IsoSimpleType.PhoneNumber)]
    public required IsoPhoneNumber PhoneNumber { get; init; } 
    
    /// <summary>
    /// Electronic mail (e-mail) address of the of the person responsible for the report.
    /// </summary>
    [IsoId("__TBPZS1AEeqVb9PEK4pNyA")]
    [DisplayName("Email Address")]
    [IsoXmlTag("EmailAdr")]
    [IsoSimpleType(IsoSimpleType.Max256Text)]
    [StringLength(maximumLength: 256 ,MinimumLength = 1)]
    public required IsoMax256Text EmailAddress { get; init; } 
    
    /// <summary>
    /// Function of the person responsible for the report.
    /// </summary>
    [IsoId("__TBPZy1AEeqVb9PEK4pNyA")]
    [DisplayName("Function")]
    [IsoXmlTag("Fctn")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public IsoMax140Text? Function { get; init; } 
    
    
    #nullable disable
    
}
