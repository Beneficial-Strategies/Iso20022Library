// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate10Choice
{
    /// <inheritdoc cref="IOriginalMandateIdentification"/>
    [DisplayName("Original Mandate Identification")]
    public partial record OriginalMandateIdentification : OriginalMandate10Choice_
    {
        /// <inheritdoc cref="IOriginalMandateIdentification.Value"/>
        [IsoXmlTag("OrgnlMndtId")]
        public required IsoMax35Text Value { get; init; }
    }
}
