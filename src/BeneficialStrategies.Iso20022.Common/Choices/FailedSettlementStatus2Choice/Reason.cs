// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FailedSettlementStatus2Choice
{
    /// <summary>
    /// Reason for the failed settlement status.
    /// </summary>
    [IsoId("_DqHjMyY5EeW_ZNn8gbfY7Q")]
    [DisplayName("Reason")]
    public partial record Reason : FailedSettlementStatus2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 350 characters.
        /// </summary>
        [IsoXmlTag("Rsn")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public required IsoMax350Text Value { get; init; } 
        
        
        #nullable disable
        
    }
}
