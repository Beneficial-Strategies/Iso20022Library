// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Status31Choice
{
    /// <summary>
    /// Status of the transfer cancellation is complete. The cancellation instruction has been accepted and processed, the cancellation is complete.
    /// </summary>
    [IsoId("_ym2jxZM6EemKz5EOjv82iQ")]
    [DisplayName("Complete")]
    public partial record Complete : Status31Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Reason for the cancelled complete status.
        /// </summary>
        [IsoId("_YeeSACYwEeW_ZNn8gbfY7Q")]
        [DisplayName("Reason")]
        [IsoXmlTag("Rsn")]
        public required CancellationCompleteReason1Choice_ Reason { get; init; } 
        
        /// <summary>
        /// Additional information about the cancelled complete status reason.
        /// </summary>
        [IsoId("_aJTcJCYwEeW_ZNn8gbfY7Q")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public IsoMax350Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
