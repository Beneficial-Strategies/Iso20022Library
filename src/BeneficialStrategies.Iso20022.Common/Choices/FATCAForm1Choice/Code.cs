// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FATCAForm1Choice
{
    /// <summary>
    /// Type of Foreign Account Tax Compliance Act (FATCA) form expressed as a code.
    /// </summary>
    [IsoId("_gPPrkAjLEeS5F6qHcKOrew")]
    [DisplayName("Code")]
    public record Code : FATCAForm1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of Foreign Account Tax Compliance Act (FATCA) form.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required FATCAFormType1Code Value { get; init; }
    }
}
