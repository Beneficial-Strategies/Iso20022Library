// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the party.
/// </summary>
[IsoId("_Vy5oUaWYEea1rLcUp8Fsgw")]
[DisplayName("Party Identification")]
public partial record PartyIdentification119
{
    #nullable enable
    
    /// <summary>
    /// Unique identification of the party.
    /// </summary>
    [IsoId("_WDtrgaWYEea1rLcUp8Fsgw")]
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public required PartyIdentification103Choice_ Identification { get; init; } 
    
    /// <summary>
    /// Legal entity identification as an alternate identification for a party.
    /// </summary>
    [IsoId("_WD21caWYEea1rLcUp8Fsgw")]
    [DisplayName("LEI")]
    [IsoXmlTag("LEI")]
    [IsoSimpleType(IsoSimpleType.LEIIdentifier)]
    public IsoLEIIdentifier? LEI { get; init; } 
    
    
    #nullable disable
    
}
