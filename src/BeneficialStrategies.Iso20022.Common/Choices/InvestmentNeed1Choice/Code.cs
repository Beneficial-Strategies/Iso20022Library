// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestmentNeed1Choice
{
    /// <summary>
    /// Investment need expressed as a code.
    /// </summary>
    [IsoId("_PXfw0DcdEeidBoT_PugKiA")]
    [DisplayName("Code")]
    public record Code : InvestmentNeed1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies an investment need.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentNeed1Code Value { get; init; }
    }
}
