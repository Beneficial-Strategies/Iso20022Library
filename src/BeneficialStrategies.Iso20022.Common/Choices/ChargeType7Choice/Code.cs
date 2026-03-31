// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType7Choice
{
    /// <summary>
    /// Cost or charge expressed as a code.
    /// </summary>
    [IsoId("_zDuYMDcnEeidBoT_PugKiA")]
    [DisplayName("Code")]
    public record Code : ChargeType7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of cost or charge.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundMiFIDFee1Code Value { get; init; }
    }
}
