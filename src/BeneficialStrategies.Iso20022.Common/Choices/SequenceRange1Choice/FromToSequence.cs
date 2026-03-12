// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SequenceRange1Choice
{
    /// <summary>
    /// Particular sequence range specified between a start sequence and an end sequence.
    /// </summary>
    [IsoId("_64OLoIy3EeeGkvZr3jtnCQ")]
    [DisplayName("From To Sequence")]
    public partial record FromToSequence : SequenceRange1Choice_
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
}
