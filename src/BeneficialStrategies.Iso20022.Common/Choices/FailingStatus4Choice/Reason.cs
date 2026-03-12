// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FailingStatus4Choice
{
    /// <summary>
    /// Specifies the reason of the FailingStatus.
    /// </summary>
    [IsoId("_Fe4Y4f7rEeCvPoRGOxRobQ")]
    [DisplayName("Reason")]
    public partial record Reason : FailingStatus4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Specifies the reason why the instruction has a failing status.
        /// </summary>
        [IsoId("_NP0JAxqLEeG38P9Gj2JZJw")]
        [DisplayName("Code")]
        [IsoXmlTag("Cd")]
        public required FailingReason4Choice_ Code { get; init; } 
        
        /// <summary>
        /// Provides additional reason information that cannot be provided in a structured field.
        /// </summary>
        [IsoId("_NP0JDRqLEeG38P9Gj2JZJw")]
        [DisplayName("Additional Reason Information")]
        [IsoXmlTag("AddtlRsnInf")]
        [IsoSimpleType(IsoSimpleType.Max210Text)]
        [StringLength(maximumLength: 210 ,MinimumLength = 1)]
        public IsoMax210Text? AdditionalReasonInformation { get; init; } 
        
        
        #nullable disable
        
    }
}
