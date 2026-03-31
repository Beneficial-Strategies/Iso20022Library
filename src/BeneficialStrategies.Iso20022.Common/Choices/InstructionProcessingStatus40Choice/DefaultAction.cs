// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus40Choice
{
    /// <summary>
    /// Default action is taken.
    /// </summary>
    [IsoId("_bHlEg-6BEeqc-LCjwLsUVg")]
    [DisplayName("Default Action")]
    public record DefaultAction : InstructionProcessingStatus40Choice_
    {
        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_UatOwNp-Ed-ak6NoX_4Aeg_137164408")]
        [DisplayName("No Specified Reason")]
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode NoSpecifiedReason { get; init; }
    }
}
