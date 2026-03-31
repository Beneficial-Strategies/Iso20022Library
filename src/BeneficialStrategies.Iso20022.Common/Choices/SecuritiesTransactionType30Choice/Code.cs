// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionType30Choice
{
    /// <summary>
    /// Securities transaction type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_8VKXg5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : SecuritiesTransactionType30Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies underlying information regarding the type of transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SecuritiesTransactionType16Code Value { get; init; }
    }
}
