// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of a party.
/// </summary>
[IsoId("_Q9aTcz6BEemPvNTzinB5Vw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification218
{
    #nullable enable
    
    /// <summary>
    /// Role played by the third party.
    /// </summary>
    [IsoId("_5561AI6VEemzmeK8_tPygg")]
    [DisplayName("Role")]
    [IsoXmlTag("Role")]
    public required PartyRole6Choice_ Role { get; init; } 
    
    /// <summary>
    /// Identification of the third party.
    /// </summary>
    [IsoId("_qSleUI6WEemzmeK8_tPygg")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification205Choice_ Identification { get; init; } 
    
    
    #nullable disable
    
}
