// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeMarket1Choice
{
    /// <summary>
    /// Standard trade market code.
    /// </summary>
    [IsoId("_NzE0NzQ4-AOSNFX-5096945")]
    [DisplayName("Code")]
    public record Code : TradeMarket1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external trade market code in the format of character string with a maximum length of 4 characters.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalTradeMarket1Code Value { get; init; }
    }
}
