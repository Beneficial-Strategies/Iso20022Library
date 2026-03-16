// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LimitIdentification3Choice
{
    /// <summary>
    /// Default.
    /// </summary>
    [DisplayName("Default")]
    public record Default : LimitIdentification3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Dflt")]
        public required LimitIdentification8 Value { get; init; }
    }
}
