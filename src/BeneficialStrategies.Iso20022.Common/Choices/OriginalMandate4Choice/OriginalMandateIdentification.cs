// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate4Choice
{
    /// <inheritdoc cref="IOriginalMandateIdentification"/>
    [IsoId("_c4CjY0jwEeaVLL5QKJ4f-A")]
    [DisplayName("Original Mandate Identification")]
    public partial record OriginalMandateIdentification : OriginalMandate4Choice_
    {
        /// <inheritdoc cref="IOriginalMandateIdentification.Value"/>
        [IsoXmlTag("OrgnlMndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
