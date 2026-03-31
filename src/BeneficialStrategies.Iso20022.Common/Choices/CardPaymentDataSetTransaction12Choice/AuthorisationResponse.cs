// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction12Choice
{
    /// <summary>
    /// Authorisation Response.
    /// </summary>
    [DisplayName("Authorisation Response")]
    public record AuthorisationResponse : CardPaymentDataSetTransaction12Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AuthstnRspn")]
        public required CardPaymentDataSetTransaction49 Value { get; init; }
    }
}
