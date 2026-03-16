// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ModelType1Choice
{
    /// <summary>
    /// Specifies the type of margin models used by a central counterparty.
    /// </summary>
    [IsoId("_v2il0I2GEeet3cKIYK84nw")]
    [DisplayName("Code")]
    public record Code : ModelType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Categorisation of margin models used by central counterparties.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ModelType1Code Value { get; init; }
    }
}
