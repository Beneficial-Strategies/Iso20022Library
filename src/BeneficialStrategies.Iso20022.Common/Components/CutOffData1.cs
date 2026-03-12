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
[IsoId("_dxXmUJXXEeaYkf5FCqYMeA")]
[DisplayName("Cut Off Data")]
public partial record CutOffData1
{
    #nullable enable
    
    /// <summary>
    /// Describes the participant receiving the net report.
    /// </summary>
    [IsoId("_d1TS4ZnvEeahw7LV9elg3w")]
    [DisplayName("Participant Identification")]
    [IsoXmlTag("PtcptId")]
    public required PartyIdentification73Choice_ ParticipantIdentification { get; init; } 
    
    /// <summary>
    /// Specifies the information regarding the updated netting cut off.
    /// </summary>
    [IsoId("_dNmEkJntEeaKH-pm9fIa8w")]
    [DisplayName("Netting Cut Off Details")]
    [IsoXmlTag("NetgCutOffDtls")]
    public ValueList<NettingCutOff1> NettingCutOffDetails { get; init; } = new ValueList<NettingCutOff1>(){}; // Warning: Don't know multiplicity.
    // ID for the above is _dNmEkJntEeaKH-pm9fIa8w
    
    
    #nullable disable
    
}
