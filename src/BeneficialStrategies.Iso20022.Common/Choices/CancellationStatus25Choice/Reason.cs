// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancellationStatus25Choice
{
    /// <summary>
    /// Specifies the reason of the cancellation status.
    /// </summary>
    [IsoId("_65Na8ffUEeiNZp_PtLohLw")]
    [DisplayName("Reason")]
    public partial record Reason : CancellationStatus25Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction is cancelled.
        /// </summary>
        [IsoId("_65Na__fUEeiNZp_PtLohLw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required CancellationReason37Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_65NbB_fUEeiNZp_PtLohLw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.RestrictedFINXMax210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoRestrictedFINXMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
