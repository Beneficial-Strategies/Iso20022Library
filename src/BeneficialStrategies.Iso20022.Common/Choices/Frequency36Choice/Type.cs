// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency36Choice
{
    /// <summary>
    /// Specifies a frequency in terms of a specified period type.
    /// </summary>
    [IsoId("_seR6MWk2Eeanu6HLe77Rkg")]
    [DisplayName("Type")]
    public record Type : Frequency36Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the regularity of an event.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required Frequency6Code Value { get; init; }
    }
}
