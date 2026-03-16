// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestComputationMethod2Choice
{
    /// <summary>
    /// Code is used to determine the interest computation method.
    /// </summary>
    [IsoId("_4-vxgNopEeCWg-hsBVGrDA_-492084439")]
    [DisplayName("Code")]
    public record Code : InterestComputationMethod2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the method used to compute accruing interest of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InterestComputationMethod1Code Value { get; init; }
    }
}
