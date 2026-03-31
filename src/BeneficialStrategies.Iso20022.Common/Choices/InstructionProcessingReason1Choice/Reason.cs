// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingReason1Choice
{
    /// <summary>
    /// Specifies the reason of the RejectedStatus.
    /// </summary>
    [IsoId("_Azyp5NokEeC60axPepSq7g_-331834835")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : InstructionProcessingReason1Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected status.
        /// </summary>
        [IsoId("_A5wH9NokEeC60axPepSq7g_-638118675")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionReason9Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional information about the reason in narrative form.
        /// </summary>
        [IsoId("_A55R4NokEeC60axPepSq7g_-1618589435")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
