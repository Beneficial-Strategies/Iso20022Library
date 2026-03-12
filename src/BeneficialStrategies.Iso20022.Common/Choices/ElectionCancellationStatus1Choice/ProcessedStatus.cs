// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ElectionCancellationStatus1Choice
{
    /// <summary>
    /// Provides information about the processing status of the request.
    /// </summary>
    [IsoId("_RiiHw9p-Ed-ak6NoX_4Aeg_1800632270")]
    [DisplayName("Processed Status")]
    public partial record ProcessedStatus : ElectionCancellationStatus1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// The processing status.
        /// </summary>
        [IsoId("_RlD3Vtp-Ed-ak6NoX_4Aeg_-1520950491")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required ProcessedStatus5FormatChoice_ Status { get; init; } 
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RlD3V9p-Ed-ak6NoX_4Aeg_-1520950490")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
