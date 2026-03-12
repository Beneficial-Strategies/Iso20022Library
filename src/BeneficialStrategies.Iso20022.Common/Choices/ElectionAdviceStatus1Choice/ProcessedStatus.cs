// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ElectionAdviceStatus1Choice
{
    /// <summary>
    /// Provides information about the processing status of advice.
    /// </summary>
    [IsoId("_RiiHwNp-Ed-ak6NoX_4Aeg_-202517044")]
    [DisplayName("Processed Status")]
    public partial record ProcessedStatus : ElectionAdviceStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The processing status.
        /// </summary>
        [IsoId("_RknyeNp-Ed-ak6NoX_4Aeg_-1029069131")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required ProcessedStatus3FormatChoice_ Status { get; init; } 
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_Rkw8YNp-Ed-ak6NoX_4Aeg_-744625301")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
