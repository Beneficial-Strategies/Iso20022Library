// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PaymentInstrument27Choice
{
    /// <summary>
    /// Credit Transfer Details.
    /// </summary>
    [DisplayName("Credit Transfer Details")]
    public record CreditTransferDetails : PaymentInstrument27Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("CdtTrfDtls")]
        public required CreditTransfer10 Value { get; init; }
    }
}
