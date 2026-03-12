// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InRepairStatus2Choice
{
    /// <summary>
    /// Reason for an in repair status in the report.
    /// </summary>
    [IsoId("_Ut7sxNp-Ed-ak6NoX_4Aeg_1844290663")]
    [DisplayName("Reason")]
    public partial record Reason : InRepairStatus2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the in repair status in textual form.
        /// </summary>
        [IsoId("_UuFdwtp-Ed-ak6NoX_4Aeg_-1922423004")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
