// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AcceptedStatus7Choice
{
    /// <summary>
    /// Reason for the accepted status.
    /// </summary>
    [IsoId("_KtgQAzt6EeW638lNyHKv7A")]
    [DisplayName("Reason")]
    public partial record Reason : AcceptedStatus7Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction has been accepted.
        /// </summary>
        [IsoId("_LN8Dkzt6EeW638lNyHKv7A")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required AcceptedReason9Choice_ ReasonCode { get; init; } 
        
        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_LN8Dlzt6EeW638lNyHKv7A")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
