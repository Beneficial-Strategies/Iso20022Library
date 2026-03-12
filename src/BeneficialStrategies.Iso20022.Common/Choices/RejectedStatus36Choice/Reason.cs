// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.RejectedStatus36Choice
{
    /// <summary>
    /// Reason why the meeting instruction message or the individual meeting instruction is rejected.
    /// </summary>
    [IsoId("_cVfl2fNfEeqRfth943bvEA")]
    [DisplayName("Reason")]
    public partial record Reason : RejectedStatus36Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the rejected status.
        /// </summary>
        [IsoId("_cp36Y_NfEeqRfth943bvEA")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required RejectedReason36Choice_ ReasonCode { get; init; } 
        
        /// <summary>
        /// Additional information about the rejection status.
        /// </summary>
        [IsoId("_cp36a_NfEeqRfth943bvEA")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
