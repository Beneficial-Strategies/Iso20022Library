// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationStatus6Choice
{
    /// <summary>
    /// Duplicate Of.
    /// </summary>
    [DisplayName("Duplicate Of")]
    public record DuplicateOf : InvestigationStatus6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("DplctOf")]
        public required Case6 Value { get; init; }
    }
}
