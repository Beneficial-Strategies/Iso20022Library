// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnmatchedStatus12Choice
{
    /// <summary>
    /// Specifies the reason of the UnmatchedStatus.
    /// </summary>
    [IsoId("_q5xL6SwREeOEV5XHD-BKpw")]
    [DisplayName("Reason")]
    public partial record Reason : UnmatchedStatus12Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction has an unmatched status.
        /// </summary>
        [IsoId("_CT8XUSwSEeOEV5XHD-BKpw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required UnmatchedReason14Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_CT8XWSwSEeOEV5XHD-BKpw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
