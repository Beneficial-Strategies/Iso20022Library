// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InRepairStatusReason4Choice
{
    /// <summary>
    /// Reason for the in repair status, expressed as a code.
    /// </summary>
    [IsoId("_Bptp5UHqEea8I67lh6qdSQ")]
    [DisplayName("Reason Details")]
    public partial record ReasonDetails : InRepairStatusReason4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the in repair status expressed as a code.
        /// </summary>
        [IsoId("_Hxv_IUHqEea8I67lh6qdSQ")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required InRepairStatusReason5Choice_ Reason { get; init; } 
        
        /// <summary>
        /// Additional information about the in repair reason.
        /// </summary>
        [IsoId("_Hxv_I0HqEea8I67lh6qdSQ")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
