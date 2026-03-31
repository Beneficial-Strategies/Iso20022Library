// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityIdentification38Choice
{
    /// <summary>
    /// Common.
    /// </summary>
    [DisplayName("Common")]
    public record Common : SecurityIdentification38Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Cmon")]
        public required IsoEuroclearClearstreamIdentifier Value { get; init; }
    }
}
