// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Entity involved in an activity.
/// </summary>
[IsoId("_PcH059p-Ed-ak6NoX_4Aeg_658182618")]
[DisplayName("Party Identification")]
public partial record PartyIdentification28
{
    #nullable enable
    
    /// <summary>
    /// Name by which a party is known and which is usually used to identify that party.
    /// </summary>
    [IsoId("_PcH06Np-Ed-ak6NoX_4Aeg_658182958")]
    [DisplayName("Name")]
    [IsoXmlTag("Nm")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public required IsoMax70Text Name { get; init; } 
    
    /// <summary>
    /// Unique and unambiguous identifier assigned to a party using a proprietary identification scheme.
    /// </summary>
    [IsoId("_PcRl4Np-Ed-ak6NoX_4Aeg_658183050")]
    [DisplayName("Proprietary Identification")]
    [IsoXmlTag("PrtryId")]
    public GenericIdentification4? ProprietaryIdentification { get; init; } 
    
    
    #nullable disable
    
}
