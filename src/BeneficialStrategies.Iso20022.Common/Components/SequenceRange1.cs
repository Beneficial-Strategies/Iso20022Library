// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices;
using BeneficialStrategies.Iso20022.ExternalSchema;
using BeneficialStrategies.Iso20022.UserDefined;
using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Components;

/// <summary>
/// Specifies a range of sequences from a start sequence to an end sequence.
/// </summary>
[IsoId("_22wBoIy0EeeGkvZr3jtnCQ")]
[DisplayName("Sequence Range")]
public partial record SequenceRange1
{
    #nullable enable
    
    /// <summary>
    /// Start sequence of the range.
    /// </summary>
    [IsoId("_9nPeAIy0EeeGkvZr3jtnCQ")]
    [DisplayName("From Sequence")]
    [IsoXmlTag("FrSeq")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text FromSequence { get; init; } 
    
    /// <summary>
    /// End sequence of the range.
    /// </summary>
    [IsoId("__3Gn0Iy0EeeGkvZr3jtnCQ")]
    [DisplayName("To Sequence")]
    [IsoXmlTag("ToSeq")]
    [IsoSimpleType(IsoSimpleType.Max35Text)]
    [StringLength(maximumLength: 35 ,MinimumLength = 1)]
    public required IsoMax35Text ToSequence { get; init; } 
    
    
    #nullable disable
    
}
