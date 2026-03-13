// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Contains the new, current and previous cut offs for a netting cut off held at the central system.
/// </summary>
[IsoId("_B5DK5wN1Ee2-vqzwMUAewg")]
[DisplayName("Cut Off Data")]
public partial record CutOffData2
{
    #nullable enable
    
    /// <summary>
    /// Describes the participant receiving the net report.
    /// </summary>
    [IsoId("_B-238QN1Ee2-vqzwMUAewg")]
    [DisplayName("Participant Identification")]
    [IsoXmlTag("PtcptId")]
    public required PartyIdentification242Choice_ ParticipantIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the information regarding the updated netting cut off.
    /// </summary>
    [IsoId("_B-238wN1Ee2-vqzwMUAewg")]
    [DisplayName("Netting Cut Off Details")]
    [IsoXmlTag("NetgCutOffDtls")]
    public ValueList<NettingCutOff2> NettingCutOffDetails { get; init; } = [];
    // ID for the above is _B-238wN1Ee2-vqzwMUAewg
    
    
    #nullable disable
    
}
