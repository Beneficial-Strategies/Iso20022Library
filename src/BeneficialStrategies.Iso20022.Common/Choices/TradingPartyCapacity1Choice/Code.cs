// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradingPartyCapacity1Choice
{
    /// <summary>
    /// Trading capacity expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_AXUwVdokEeC60axPepSq7g_-1681315907")]
    [DisplayName("Code")]
    public record Code : TradingPartyCapacity1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of a trading party in a transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TradingCapacity4Code Value { get; init; }
    }
}
