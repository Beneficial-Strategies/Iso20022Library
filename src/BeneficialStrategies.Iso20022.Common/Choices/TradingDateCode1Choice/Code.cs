// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradingDateCode1Choice
{
    /// <summary>
    /// Trading date expressed as a ISO20022 code.
    /// </summary>
    [IsoId("_AXUwUtokEeC60axPepSq7g_2017039094")]
    [DisplayName("Code")]
    public record Code : TradingDateCode1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Trading Date Code.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TradingDate1Code Value { get; init; }
    }
}
