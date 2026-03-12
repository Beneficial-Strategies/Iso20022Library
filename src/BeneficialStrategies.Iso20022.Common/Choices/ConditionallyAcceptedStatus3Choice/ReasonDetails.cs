// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ConditionallyAcceptedStatus3Choice
{
    /// <summary>
    /// Reason for the conditionally accepted status, expressed as a code.
    /// </summary>
    [IsoId("_s1kxx0HXEeamVPoS58KxXA")]
    [DisplayName("Reason Details")]
    public partial record ReasonDetails : ConditionallyAcceptedStatus3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the conditionally accepted status expressed as a code.
        /// </summary>
        [IsoId("_84wPkEHZEeamVPoS58KxXA")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required ConditionallyAcceptedStatusReason3Choice_ Reason { get; init; } 
        
        /// <summary>
        /// Additional information about the conditionally accepted reason.
        /// </summary>
        [IsoId("_BL11YEHaEeamVPoS58KxXA")]
        [DisplayName("Additional Information")]
        [IsoXmlTag("AddtlInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
