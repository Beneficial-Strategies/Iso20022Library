// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InvestorRestrictionType3Choice
{
    /// <summary>
    /// Investor restriction type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_dPETIeLxEeWOD7aAy2fAcA")]
    [DisplayName("Code")]
    public record Code : InvestorRestrictionType3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies to whom or what the restriction applies.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestorRestrictionType1Code Value { get; init; }
    }
}
