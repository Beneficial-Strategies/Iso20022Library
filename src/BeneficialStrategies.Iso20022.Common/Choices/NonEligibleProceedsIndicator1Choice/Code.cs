// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.NonEligibleProceedsIndicator1Choice
{
    /// <summary>
    /// Standard code to specify information regarding the non eligibility of the outturn resources.
    /// </summary>
    [IsoId("_Q5QhQNp-Ed-ak6NoX_4Aeg_-1187456138")]
    [DisplayName("Code")]
    public record Code : NonEligibleProceedsIndicator1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies information regarding the non eligibility of the outturn resources.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required NonEligibleProceedsIndicator1Code Value { get; init; }
    }
}
