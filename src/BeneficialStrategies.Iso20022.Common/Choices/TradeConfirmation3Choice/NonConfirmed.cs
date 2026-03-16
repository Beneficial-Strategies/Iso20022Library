// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TradeConfirmation3Choice
{
    /// <summary>
    /// Indicates that contract was not confirmed.
    /// </summary>
    [IsoId("_PQNwE1o3Ee23K4GXSpBSeg")]
    [DisplayName("Non Confirmed")]
    public record NonConfirmed : TradeConfirmation3Choice_
    {
        /// <summary>
        /// Specifies that the contract remains unconfirmed.
        /// </summary>
        [IsoId("_8sHJ5w27EeWmAKKPnqYEVQ")]
        [DisplayName("Type")]
        [IsoXmlTag("Tp")]
        public required TradeConfirmationType2Code Type { get; init; }
    }
}
