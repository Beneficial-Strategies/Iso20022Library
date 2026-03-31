// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestigationReason1Choice
{
    /// <summary>
    /// Proprietary.
    /// </summary>
    [DisplayName("Proprietary")]
    public record Proprietary : InvestigationReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax35Text Value { get; init; }
    }
}
