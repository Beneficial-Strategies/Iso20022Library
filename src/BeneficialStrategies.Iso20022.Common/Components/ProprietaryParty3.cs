// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identifies a proprietary party.
/// </summary>
[IsoId("_tqlwIlkyEeGeoaLUQk__nA_-556351035")]
[DisplayName("Proprietary Party")]
public partial record ProprietaryParty3
{
    #nullable enable
    
    /// <summary>
    /// Specifies the type of proprietary party.
    /// </summary>
    [IsoId("_tqvhIFkyEeGeoaLUQk__nA_-1553423388")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Proprietary party.
    /// </summary>
    [IsoId("_tqvhIVkyEeGeoaLUQk__nA_1597922833")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification43 Party { get; init; } 
    
    
    #nullable disable
    
}
