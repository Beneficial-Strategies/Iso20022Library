// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AffirmationReason2Choice
{
    /// <summary>
    /// Specifies the reason of the UnaffirmedStatus.
    /// </summary>
    [IsoId("_YFYT8wd3Ee2fOITqoTnSLQ")]
    [DisplayName("Reason")]
    public partial record Reason : AffirmationReason2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction/request has a unaffirmed status.
        /// </summary>
        [IsoId("_YYTP8Qd3Ee2fOITqoTnSLQ")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required UnaffirmedReason3Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional information about the reason in narrative form.
        /// </summary>
        [IsoId("_YYTP8wd3Ee2fOITqoTnSLQ")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
