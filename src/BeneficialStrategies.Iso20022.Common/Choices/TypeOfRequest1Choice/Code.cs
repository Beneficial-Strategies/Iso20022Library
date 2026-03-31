// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TypeOfRequest1Choice
{
    /// <summary>
    /// Type of request expressed as a code.
    /// </summary>
    [IsoId("_1DwE4NvdEeqxGfKJubfhIw")]
    [DisplayName("Code")]
    public record Code : TypeOfRequest1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of request.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TypeOfRequest1Code Value { get; init; }
    }
}
