// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency37Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_GlS6xWoFEearR-CA7eRZXQ")]
    [DisplayName("Code")]
    public partial record Code : Frequency37Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required Frequency10Code Value { get; init; }
    }
}
