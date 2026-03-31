// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.GeneralInvestmentAccountType1Choice
{
    /// <summary>
    /// Type of investment account expressed as a code.
    /// </summary>
    [IsoId("_mog4IF2cEeiFXdiLi_Nf4A")]
    [DisplayName("Code")]
    public record Code : GeneralInvestmentAccountType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of investment account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GeneralInvestmentAccountType1Code Value { get; init; }
    }
}
