// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus2Choice
{
    /// <summary>
    /// Status advising on the processing of the cancellation request.
    /// </summary>
    [IsoId("_RCy3wdp-Ed-ak6NoX_4Aeg_-815488210")]
    [DisplayName("Processing Status")]
    public partial record ProcessingStatus : CancellationStatus2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Status of the request for cancellation.
        /// </summary>
        [IsoId("_RVkCx9p-Ed-ak6NoX_4Aeg_-1468645420")]
        [DisplayName("Status")]
        [IsoXmlTag("Sts")]
        public required CancellationStatus3Code Status { get; init; } 
        
        /// <summary>
        /// Additional information about the status.
        /// </summary>
        [IsoId("_RVkCyNp-Ed-ak6NoX_4Aeg_-1468645405")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
