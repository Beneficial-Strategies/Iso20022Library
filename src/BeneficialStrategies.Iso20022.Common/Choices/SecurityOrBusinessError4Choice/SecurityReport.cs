// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecurityOrBusinessError4Choice
{
    /// <summary>
    /// Provides the financial instruments details.
    /// </summary>
    [IsoId("_P7y44ZJKEeuAlLVx8pyt3w")]
    [DisplayName("Security Report")]
    [IsoXmlTag("SctyRpt")]
    public record SecurityReport : SecurityOrBusinessError4Choice_
    {
        /// <summary>
        /// Way(s) of identifying the security.
        /// </summary>
        [IsoId("_QAKbgZJKEeuAlLVx8pyt3w")]
        [DisplayName("Financial Instrument Identification")]
        [IsoXmlTag("FinInstrmId")]
        public SecurityIdentification39? FinancialInstrumentIdentification { get; init; }

        /// <summary>
        /// Provides additional details about the financial instrument.
        /// </summary>
        [IsoId("_QAKbg5JKEeuAlLVx8pyt3w")]
        [DisplayName("Financial Instrument Type")]
        [IsoXmlTag("FinInstrmTp")]
        public FinancialInstrument97? FinancialInstrumentType { get; init; }

        /// <summary>
        /// Financial instruments representing a sum of rights of the investor vis-a-vis the issuer.
        /// </summary>
        [IsoId("_QAKbhZJKEeuAlLVx8pyt3w")]
        [DisplayName("Financial Instrument Attributes")]
        [IsoXmlTag("FinInstrmAttrbts")]
        public CommonFinancialInstrumentAttributes11? FinancialInstrumentAttributes { get; init; }
    }
}
