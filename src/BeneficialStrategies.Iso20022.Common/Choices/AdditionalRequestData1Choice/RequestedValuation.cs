// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.AdditionalRequestData1Choice
{
    /// <summary>
    /// Requested Valuation.
    /// </summary>
    [DisplayName("Requested Valuation")]
    public record RequestedValuation : AdditionalRequestData1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ReqdValtn")]
        public required AdjustmentRequest1 Value { get; init; }
    }
}
