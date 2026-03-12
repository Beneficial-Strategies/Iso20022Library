// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AcknowledgedAcceptedStatus14Choice
{
    /// <summary>
    /// Specifies the reason of the AcknowledgedAcceptedStatus.
    /// </summary>
    [IsoId("_0jYTAwlIEeGATtfOBToyew_-1163896622")]
    [DisplayName("Reason")]
    public partial record Reason : AcknowledgedAcceptedStatus14Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Choice of format for the acknowledgement reason.
        /// </summary>
        [IsoId("_0jOiBAlIEeGATtfOBToyew_247794210")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required AcknowledgementReason9Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_0jYTAAlIEeGATtfOBToyew_-143237910")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
