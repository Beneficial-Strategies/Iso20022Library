// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CustomerConductClassification1Choice
{
    /// <summary>
    /// Conduct type expressed as a code.
    /// </summary>
    [IsoId("_XdT2cBdwEeKYM7Bc71nDlA")]
    [DisplayName("Code")]
    public record Code : CustomerConductClassification1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the classification of the conduct.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ConductClassification1Code Value { get; init; }
    }
}
