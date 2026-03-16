// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InterestComputationMethodFormat6Choice
{
    /// <summary>
    /// Standard code to specify the method used to compute accruing interest of a financial instrument.
    /// </summary>
    [IsoId("_oDMjMyDuEeahCJeThTBhHA")]
    [DisplayName("Code")]
    public record Code : InterestComputationMethodFormat6Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the method used to compute accruing interest of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InterestComputationMethod1Code Value { get; init; }
    }
}
