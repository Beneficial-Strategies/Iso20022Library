// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loyalty Programme4.
/// </summary>
[IsoId("_skOKIXNREe6Y1uOeeiF_Eg")]
[DisplayName("Loyalty Programme4")]
public partial record LoyaltyProgramme4
{
    #nullable enable

    /// <summary>
    /// Identification.
    /// </summary>
    [DisplayName("Identification")]
    [IsoXmlTag("Id")]
    public IsoMax70Text? Identification { get; init; } 

    /// <summary>
    /// Participant Identification.
    /// </summary>
    [DisplayName("Participant Identification")]
    [IsoXmlTag("PtcptId")]
    public IsoMax70Text? ParticipantIdentification { get; init; } 

    /// <summary>
    /// Type.
    /// </summary>
    [DisplayName("Type")]
    [IsoXmlTag("Tp")]
    public IsoMax35Text? Type { get; init; } 

    
    #nullable disable
    
}
