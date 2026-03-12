// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationReason11Choice
{
    /// <summary>
    /// Specifies the reason of the CancellationPending Status.
    /// </summary>
    [IsoId("_A0Fk0tokEeC60axPepSq7g_-754464307")]
    [DisplayName("Reason")]
    public partial record Reason : CancellationReason11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the trade is wainting the cancellation.
        /// </summary>
        [IsoId("_A4QTI9okEeC60axPepSq7g_468504025")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required AwaitingCancellationReason1Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional information about the reason in narrative form.
        /// </summary>
        [IsoId("_A4QTJNokEeC60axPepSq7g_-414729262")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
