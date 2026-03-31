// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice3Choice
{
    /// <summary>
    /// Indicates that price is currently not available, but pending.
    /// </summary>
    [IsoId("_rdXYB0DWEeWOL-OsSq2h6w")]
    [DisplayName("Pending Price")]
    public record PendingPrice : SecuritiesTransactionPrice3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the status of the price of a financial instrument.
        /// </summary>
        [IsoXmlTag("PdgPric")]
        public required PriceStatus1Code Value { get; init; }
    }
}
