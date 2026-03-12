// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AcceptedStatus10Choice
{
    /// <summary>
    /// Reason for the accepted status.
    /// </summary>
    [IsoId("_6HWbkZNLEeWGlc8L7oPDIg")]
    [DisplayName("Reason")]
    public partial record Reason : AcceptedStatus10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction has been accepted.
        /// </summary>
        [IsoId("_6HWbm5NLEeWGlc8L7oPDIg")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required AcceptedReason12Choice_ ReasonCode { get; init; } 
        
        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_6HWbn5NLEeWGlc8L7oPDIg")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
