// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ConsolidationType1Choice
{
    /// <summary>
    /// Consolidation type expressed as a code.
    /// </summary>
    [IsoId("_QFc8kCDVEeWCLu74WLgP4w")]
    [DisplayName("Code")]
    public record Code : ConsolidationType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the consolidation type.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ConsolidationType1Code Value { get; init; }
    }
}
