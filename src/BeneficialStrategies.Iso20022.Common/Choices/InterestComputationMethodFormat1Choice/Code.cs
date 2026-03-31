// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestComputationMethodFormat1Choice
{
    /// <summary>
    /// Standard code to specify the method used to compute accruing interest of a financial instrument.
    /// </summary>
    [IsoId("_Q4NYbNp-Ed-ak6NoX_4Aeg_893786945")]
    [DisplayName("Code")]
    public record Code : InterestComputationMethodFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the method used to compute accruing interest of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InterestComputationMethod2Code Value { get; init; }
    }
}
