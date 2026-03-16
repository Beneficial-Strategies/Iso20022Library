// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.QuotationType1Choice
{
    /// <summary>
    /// Type of quotation expressed as a code.
    /// </summary>
    [IsoId("_ZSNVcNK4EeihtcVwfFPNlg")]
    [DisplayName("Code")]
    public record Code : QuotationType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of quotation.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required QuotationType1Code Value { get; init; }
    }
}
