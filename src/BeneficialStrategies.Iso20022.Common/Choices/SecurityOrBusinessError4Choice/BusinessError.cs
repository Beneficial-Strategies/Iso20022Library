// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityOrBusinessError4Choice
{
    /// <summary>
    /// Provides the business error details.
    /// </summary>
    [IsoId("_P7y445JKEeuAlLVx8pyt3w")]
    [DisplayName("Business Error")]
    public record BusinessError : SecurityOrBusinessError4Choice_
    {
        /// <summary>
        /// Way(s) of identifying the security.
        /// </summary>
        [IsoId("_P-BGcZJKEeuAlLVx8pyt3w")]
        [DisplayName("Financial Instrument Identification")]
        [IsoXmlTag("FinInstrmId")]
        public required SecurityIdentification39 FinancialInstrumentIdentification { get; init; }

        /// <summary>
        /// Provides the business error.
        /// </summary>
        [IsoXmlTag("BizErr")]
        public ValueList<ErrorHandling5> Value { get; init; } = [];
    }
}
