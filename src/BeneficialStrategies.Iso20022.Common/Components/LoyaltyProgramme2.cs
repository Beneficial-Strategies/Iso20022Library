// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Loyalty programme information
/// </summary>
[IsoId("_R1YN9PJpEeiJn9rM2Znz2w")]
[DisplayName("Loyalty Programme")]
public partial record LoyaltyProgramme2
{
    #nullable enable
    
    /// <summary>
    /// Type of loyalty programme (for example, airline, lodging, vehicle and rail etc.).
    /// </summary>
    [IsoId("_R1YN9fJpEeiJn9rM2Znz2w")]
    [DisplayName("Programme Type")]
    [IsoXmlTag("PrgrmmTp")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public IsoMax35Text? ProgrammeType { get; init; } 
    
    /// <summary>
    /// Loyalty programme identification value.
    /// </summary>
    [IsoId("_R1YN9vJpEeiJn9rM2Znz2w")]
    [DisplayName("Program Identification")]
    [IsoXmlTag("PrgmId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? ProgramIdentification { get; init; } 
    
    /// <summary>
    /// Loyalty programme participant identification value.
    /// </summary>
    [IsoId("_R1YN9_JpEeiJn9rM2Znz2w")]
    [DisplayName("Participant Identification")]
    [IsoXmlTag("PtcptId")]
    [IsoSimpleType(IsoSimpleType.Max70Text)]
    [StringLength(maximumLength: 70 ,MinimumLength = 1)]
    public IsoMax70Text? ParticipantIdentification { get; init; } 
    
    
    #nullable disable
    
}
