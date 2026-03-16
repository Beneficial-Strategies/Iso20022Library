// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction13Choice
{
    /// <summary>
    /// Token Response.
    /// </summary>
    [DisplayName("Token Response")]
    public record TokenResponse : CardPaymentDataSetTransaction13Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("TknRspn")]
        public required TokenRequestComponent5 Value { get; init; }
    }
}
