// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CardPaymentDataSetTransaction13Choice
{
    /// <summary>
    /// Completion.
    /// </summary>
    [DisplayName("Completion")]
    public record Completion : CardPaymentDataSetTransaction13Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Cmpltn")]
        public required CardPaymentDataSetTransaction51 Value { get; init; }
    }
}
