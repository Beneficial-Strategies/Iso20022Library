// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Charges6Choice
{
    /// <summary>
    /// Per Transaction.
    /// </summary>
    [DisplayName("Per Transaction")]
    public record PerTransaction : Charges6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PerTx")]
        public required ChargesPerTransaction6 Value { get; init; }
    }
}
