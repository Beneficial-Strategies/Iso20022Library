// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesRTGS3Choice
{
    /// <summary>
    /// Specifies whether the settlement transaction is to be settled through an RTGS or a non RTGS system.
    /// </summary>
    [IsoId("_AZabAtokEeC60axPepSq7g_-1286368661")]
    [DisplayName("Indicator")]
    public record Indicator : SecuritiesRTGS3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates a &quot;Yes&quot; or &quot;No&quot; type of answer for an element.
        /// </summary>
        [IsoXmlTag("Ind")]
        [IsoSimpleType(IsoSimpleType.YesNoIndicator)]
        public required IsoYesNoIndicator Value { get; init; }
    }
}
