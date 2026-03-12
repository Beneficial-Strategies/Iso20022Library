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
[IsoId("_zv1wlD6BEemPvNTzinB5Vw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification201
{
    #nullable enable
    
    /// <summary>
    /// Name and address of the party.
    /// </summary>
    [IsoId("_zv1wlz6BEemPvNTzinB5Vw")]
    [DisplayName("Name And Address")]
    [IsoXmlTag("NmAndAdr")]
    public PersonName2? NameAndAddress { get; init; } 
    
    /// <summary>
    /// Identification of the party.
    /// </summary>
    [IsoId("_zv1wlj6BEemPvNTzinB5Vw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification198Choice_ Identification { get; init; } 
    
    
    #nullable disable
    
}
