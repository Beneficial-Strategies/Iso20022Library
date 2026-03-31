// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ReportContent1Choice
{
    /// <summary>
    /// Report content in text format.
    /// </summary>
    [IsoId("_TSNGoMlWEeuJ35KoBRZFOg")]
    [DisplayName("Text")]
    public record Text : ReportContent1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 10,000,000 characters.
        /// </summary>
        [IsoXmlTag("Txt")]
        [IsoSimpleType(IsoSimpleType.Max10MbText)]
        [StringLength(maximumLength: 10000000, MinimumLength = 1)]
        public required IsoMax10MbText Value { get; init; }
    }
}
