// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingReason2Choice
{
    /// <summary>
    /// Specifies the reason of the InRepairStatus.
    /// </summary>
    [IsoId("_Azo45NokEeC60axPepSq7g_228529796")]
    [DisplayName("Reason")]
    [IsoXmlTag("Rsn")]
    public record Reason : InstructionProcessingReason2Choice_
    {
        /// <summary>
        /// Specifies the reason why the instruction is in repair.
        /// </summary>
        [IsoId("_A5mW9NokEeC60axPepSq7g_1225602149")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RepairReason9Choice_ Code { get; init; }

        /// <summary>
        /// Provides additional information about the reason in narrative form.
        /// </summary>
        [IsoId("_A5mW9dokEeC60axPepSq7g_2003006841")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210, MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; }
    }
}
