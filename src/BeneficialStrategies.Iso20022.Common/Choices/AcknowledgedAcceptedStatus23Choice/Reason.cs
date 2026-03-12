// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AcknowledgedAcceptedStatus23Choice
{
    /// <summary>
    /// Specifies the reason of the acknowledged accepted status.
    /// </summary>
    [IsoId("_YBdO6Tq1EeWyoP0PbocV1Q")]
    [DisplayName("Reason")]
    public partial record Reason : AcknowledgedAcceptedStatus23Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Choice of format for the acknowledgement reason.
        /// </summary>
        [IsoId("_YhcWgTq1EeWyoP0PbocV1Q")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required AcknowledgementReason14Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_YhcWgzq1EeWyoP0PbocV1Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
