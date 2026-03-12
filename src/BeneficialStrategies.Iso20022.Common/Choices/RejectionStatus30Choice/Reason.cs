// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectionStatus30Choice
{
    /// <summary>
    /// Specifies the reason of the rejection status.
    /// </summary>
    [IsoId("_tzlZtekIEemm4qhb2yFPOw")]
    [DisplayName("Reason")]
    public partial record Reason : RejectionStatus30Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction/request has a rejected or repair status.
        /// </summary>
        [IsoId("_uaQ_MekIEemm4qhb2yFPOw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required RejectionReason37Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_uaQ_NekIEemm4qhb2yFPOw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
