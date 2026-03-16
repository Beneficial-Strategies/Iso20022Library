// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FATCAStatus1Choice
{
    /// <summary>
    /// Foreign Account Tax Compliance Act (FATCA) status expressed as a code.
    /// </summary>
    [IsoId("_5yPV8AjREeS5F6qHcKOrew")]
    [DisplayName("Code")]
    public record Code : FATCAStatus1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the Foreign Account Tax Compliance Act (FATCA) status.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FATCAStatus1Code Value { get; init; }
    }
}
