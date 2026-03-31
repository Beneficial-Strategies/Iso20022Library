// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradingPartyCapacity3Choice
{
    /// <summary>
    /// Trading capacity expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_YaVioY-1Eeaoj_JbcpWKgg")]
    [DisplayName("Code")]
    public record Code : TradingPartyCapacity3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role of a trading party in a transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TradingCapacity6Code Value { get; init; }
    }
}
