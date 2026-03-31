// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentIdentification8Choice
{
    /// <summary>
    /// Short Business Identification.
    /// </summary>
    [DisplayName("Short Business Identification")]
    public record ShortBusinessIdentification : PaymentIdentification8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ShrtBizId")]
        public required ShortPaymentIdentification4 Value { get; init; }
    }
}
