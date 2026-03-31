// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.IntraBalanceOrOperationalError12Choice
{
    /// <summary>
    /// Modifications.
    /// </summary>
    [DisplayName("Modifications")]
    public record Modifications : IntraBalanceOrOperationalError12Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Mods")]
        public required IntraBalanceModification7 Value { get; init; }
    }
}
