// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OriginalMandate6Choice
{
    /// <inheritdoc cref="IOriginalMandateIdentification"/>
    [IsoId("_HtlUo249EeiU9cctagi5ow")]
    [DisplayName("Original Mandate Identification")]
    public partial record OriginalMandateIdentification : OriginalMandate6Choice_
    {
        /// <inheritdoc cref="IOriginalMandateIdentification.Value"/>
        [IsoXmlTag("OrgnlMndtId")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
