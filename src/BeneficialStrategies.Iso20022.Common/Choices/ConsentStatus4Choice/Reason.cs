// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ConsentStatus4Choice
{
    /// <summary>
    /// Reason provided for the status.
    /// </summary>
    [IsoId("_oftdyTzpEeWeNtT0s2RbkQ")]
    [DisplayName("Reason")]
    public partial record Reason : ConsentStatus4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason provided for the status.
        /// </summary>
        [IsoId("_pASbQTzpEeWeNtT0s2RbkQ")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required ConsentOrRejectionReason4Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_pASbQzzpEeWeNtT0s2RbkQ")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
