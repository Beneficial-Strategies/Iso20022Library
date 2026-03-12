// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Magnetic track or equivalent payment card data.
/// </summary>
[IsoId("_Sqk0swEcEeCQm6a_G2yO_w_184409498")]
[DisplayName("Track Data")]
public partial record TrackData1
{
    #nullable enable
    
    /// <summary>
    /// Track number of the card.
    /// </summary>
    [IsoId("_Sqk0tAEcEeCQm6a_G2yO_w_-165337927")]
    [DisplayName("Track Number")]
    [IsoXmlTag("TrckNb")]
    [IsoSimpleType(IsoSimpleType.Exact1NumericText)]
    public IsoExact1NumericText? TrackNumber { get; init; } 
    
    /// <summary>
    /// Card track content or equivalent.
    /// </summary>
    [IsoId("_Sqk0tQEcEeCQm6a_G2yO_w_-1883337047")]
    [DisplayName("Track Value")]
    [IsoXmlTag("TrckVal")]
    [IsoSimpleType(IsoSimpleType.Max140Text)]
    [StringLength(maximumLength: 140 ,MinimumLength = 1)]
    public required IsoMax140Text TrackValue { get; init; } 
    
    
    #nullable disable
    
}
