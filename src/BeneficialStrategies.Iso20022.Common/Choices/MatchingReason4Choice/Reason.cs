// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MatchingReason4Choice
{
    /// <summary>
    /// Specifies the reason of the MatchedAlleged Status.
    /// </summary>
    [IsoId("_1ZiGg2XREeOWzsrIp2keDA")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : MatchingReason4Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction has been alleged.
        /// </summary>
        [IsoId("_pC7WMWXREeOWzsrIp2keDA")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required AllegementReason1Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional information about the reason in narrative form.
        /// </summary>
        [IsoId("_pC7WM2XREeOWzsrIp2keDA")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
