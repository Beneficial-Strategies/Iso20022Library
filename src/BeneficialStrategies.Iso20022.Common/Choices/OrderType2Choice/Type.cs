// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OrderType2Choice
{
    /// <summary>
    /// Order type expressed as a code.
    /// </summary>
    [IsoId("_dOFRwVxUEeWvPv3PXpS3fw")]
    [DisplayName("Type")]
    public record Type : OrderType2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the fund order type.
        /// </summary>
        [IsoXmlTag("Tp")]
        public required FundOrderType7Code Value { get; init; }
    }
}
