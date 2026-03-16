// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SourceOfCash1Choice
{
    /// <summary>
    /// Source of cash expressed as a code.
    /// </summary>
    [IsoId("_otZG0DlEEealR6-8aQ15BA")]
    [DisplayName("Code")]
    public record Code : SourceOfCash1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the origin of cash.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SourceOfCash1Code Value { get; init; }
    }
}
