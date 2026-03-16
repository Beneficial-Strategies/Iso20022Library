// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SearchCriteria2Choice
{
    /// <summary>
    /// Payment Instrument.
    /// </summary>
    [DisplayName("Payment Instrument")]
    public record PaymentInstrument : SearchCriteria2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("PmtInstrm")]
        public required PaymentInstrumentType1 Value { get; init; }
    }
}
