// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CancelledStatus11Choice
{
    /// <summary>
    /// Reason for the cancelled status.
    /// </summary>
    [IsoId("_85EWq0GWEeWqy4niLuXETA")]
    [DisplayName("Reason")]
    public partial record Reason : CancelledStatus11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction or instruction cancellation has been cancelled.
        /// </summary>
        [IsoId("_9HM5Q0GWEeWqy4niLuXETA")]
        [DisplayName("Reason Code")]
        [IsoXmlTag("RsnCd")]
        public required CancelledReason9Choice_ ReasonCode { get; init; } 
        
        /// <summary>
        /// Provides additional information about the processed instruction.
        /// </summary>
        [IsoId("_9HM5S0GWEeWqy4niLuXETA")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
