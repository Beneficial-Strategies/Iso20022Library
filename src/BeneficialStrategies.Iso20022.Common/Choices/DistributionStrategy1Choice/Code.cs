// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DistributionStrategy1Choice
{
    /// <summary>
    /// Distribution strategy expressed as a code.
    /// </summary>
    [IsoId("_4p7P4DcgEeidBoT_PugKiA")]
    [DisplayName("Code")]
    public record Code : DistributionStrategy1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of investor.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestorType3Code Value { get; init; }
    }
}
