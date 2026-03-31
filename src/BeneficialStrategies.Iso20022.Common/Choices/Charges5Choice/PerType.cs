// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Charges5Choice
{
    /// <summary>
    /// Per Type.
    /// </summary>
    [DisplayName("Per Type")]
    public record PerType : Charges5Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PerTp")]
        public required ChargesPerType5 Value { get; init; }
    }
}
