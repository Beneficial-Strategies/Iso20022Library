// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument27Choice
{
    /// <summary>
    /// Cheque Details.
    /// </summary>
    [DisplayName("Cheque Details")]
    public record ChequeDetails : PaymentInstrument27Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("ChqDtls")]
        public required Cheque21 Value { get; init; }
    }
}
