// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InstructionProcessingStatus25Choice
{
    /// <summary>
    /// Default action is taken.
    /// </summary>
    [IsoId("_cgnRfZKQEeWHWpTQn1FFVg")]
    [DisplayName("Default Action")]
    public partial record DefaultAction : InstructionProcessingStatus25Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Indicates that there is no reason available or to report.
        /// </summary>
        [IsoId("_UatOwNp-Ed-ak6NoX_4Aeg_137164408")]
        [DisplayName("No Specified Reason")]
        [IsoXmlTag("NoSpcfdRsn")]
        public required NoReasonCode NoSpecifiedReason { get; init; } 
        
        
        #nullable disable
        
    }
}
