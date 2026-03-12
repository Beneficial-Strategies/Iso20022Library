// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Identification of the place of safekeeping expressed as a code and a BIC.
/// </summary>
[IsoId("_SfoCI9p-Ed-ak6NoX_4Aeg_1628228050")]
[DisplayName("Safekeeping Place As Code And Party Identification")]
public partial record SafekeepingPlaceAsCodeAndPartyIdentification
{
    #nullable enable
    
    /// <summary>
    /// Place of safekeeping as a code.
    /// </summary>
    [IsoId("_SfoCJNp-Ed-ak6NoX_4Aeg_-1275917504")]
    [DisplayName("Place Safekeeping")]
    [IsoXmlTag("PlcSfkpg")]
    public required SafekeepingPlace1Code PlaceSafekeeping { get; init; } 
    
    /// <summary>
    /// Additional information about the place of safekeeping.
    /// </summary>
    [IsoId("_SfoCJdp-Ed-ak6NoX_4Aeg_-379437396")]
    [DisplayName("Narrative")]
    [IsoXmlTag("Nrrtv")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? Narrative { get; init; } 
    
    /// <summary>
    /// Place of safekeeping.
    /// </summary>
    [IsoId("_SfoCJtp-Ed-ak6NoX_4Aeg_-405959313")]
    [DisplayName("Party")]
    [IsoXmlTag("Pty")]
    public PartyIdentification3? Party { get; init; } 
    
    
    #nullable disable
    
}
