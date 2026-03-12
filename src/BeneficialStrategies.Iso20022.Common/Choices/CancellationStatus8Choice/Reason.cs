// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus8Choice
{
    /// <summary>
    /// Specifies the reason of the CancellationStatus.
    /// </summary>
    [IsoId("_XGMN0f7rEeCvPoRGOxRobQ")]
    [DisplayName("Reason")]
    public partial record Reason : CancellationStatus8Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction is cancelled.
        /// </summary>
        [IsoId("_UZEQAdp-Ed-ak6NoX_4Aeg_644022432")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required CancellationReason5Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_UZEQAtp-Ed-ak6NoX_4Aeg_-1472361575")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
