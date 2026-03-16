// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingReason3Choice
{
    /// <summary>
    /// Specifies the reason of the MatchedAlleged Status.
    /// </summary>
    [IsoId("_Az7z0dokEeC60axPepSq7g_1317919921")]
    [DisplayName("Reason")]
    public record Reason : MatchingReason3Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has been alleged.
        /// </summary>
        [IsoId("_A4j1JNokEeC60axPepSq7g_-40057461")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required AllegmentReason1Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional information about the reason in narrative form.
        /// </summary>
        [IsoId("_A4j1JdokEeC60axPepSq7g_-604585106")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
