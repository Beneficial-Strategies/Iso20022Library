// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Set of elements to identify a proprietary party.
/// </summary>
[IsoId("_RUhg8Np-Ed-ak6NoX_4Aeg_1076696862")]
[DisplayName("Proprietary Party")]
public partial record ProprietaryParty1
{
    #nullable enable
    
    /// <summary>
    /// Identifies the type of proprietary party reported.
    /// </summary>
    [IsoId("_RUhg8dp-Ed-ak6NoX_4Aeg_1236467977")]
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text Type { get; init; } 
    
    /// <summary>
    /// Proprietary party.
    /// </summary>
    [IsoId("_RUhg8tp-Ed-ak6NoX_4Aeg_1598487066")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public required PartyIdentification8 Party { get; init; } 
    
    
    #nullable disable
    
}
