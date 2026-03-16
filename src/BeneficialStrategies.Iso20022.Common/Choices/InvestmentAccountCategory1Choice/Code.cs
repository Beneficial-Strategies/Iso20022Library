// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestmentAccountCategory1Choice
{
    /// <summary>
    /// Category of investment account expressed as a code.
    /// </summary>
    [IsoId("_gXhC8BRIEeOKWo1NF21OVw")]
    [DisplayName("Code")]
    public record Code : InvestmentAccountCategory1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the investment account category.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentAccountCategory1Code Value { get; init; }
    }
}
