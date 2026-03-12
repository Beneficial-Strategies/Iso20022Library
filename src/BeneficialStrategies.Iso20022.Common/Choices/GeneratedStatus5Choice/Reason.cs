// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GeneratedStatus5Choice
{
    /// <summary>
    /// Specifies the reason of the generated status.
    /// </summary>
    [IsoId("_FD3Q-SRhEeO8sskhVI3IDA")]
    [DisplayName("Reason")]
    public partial record Reason : GeneratedStatus5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the transaction was generated.
        /// </summary>
        [IsoId("_Dl-9sSRhEeO8sskhVI3IDA")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required GeneratedReasons3Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_Dl-9uSRhEeO8sskhVI3IDA")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
