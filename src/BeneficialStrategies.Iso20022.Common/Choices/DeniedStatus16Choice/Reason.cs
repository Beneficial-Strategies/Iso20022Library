// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DeniedStatus16Choice
{
    /// <summary>
    /// Specifies the reason of the denied status.
    /// </summary>
    [IsoId("_t0nF2Ts8EeWRTLSN0i0tng")]
    [DisplayName("Reason")]
    public partial record Reason : DeniedStatus16Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the request has a denied status.
        /// </summary>
        [IsoId("_uWhgETs8EeWRTLSN0i0tng")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required DeniedReason16Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_uWhgGTs8EeWRTLSN0i0tng")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
