// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.PendingStatus11Choice
{
    /// <summary>
    /// Specifies the reason of the PendingStatus.
    /// </summary>
    [IsoId("_Qg1iIf41EeClUvPNHKL9Zw")]
    [DisplayName("Reason")]
    public partial record Reason : PendingStatus11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why a cancellation request sent for the related instruction is pending.
        /// </summary>
        [IsoId("_Qg1iL_41EeClUvPNHKL9Zw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required PendingReason15Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_Qg1iOf41EeClUvPNHKL9Zw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
