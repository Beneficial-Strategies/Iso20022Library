// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TrancheIndicator2Choice
{
    /// <summary>
    /// Indicates that derivative contract is untranched.
    /// </summary>
    [IsoId("_523O0byOEeaUov4jN5X9Qw")]
    [DisplayName("Untranched")]
    public partial record Untranched : TrancheIndicator2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies that there is no reason available.
        /// </summary>
        [IsoXmlTag("Utrnchd")]
        public required NoReasonCode Value { get; init; } 
        
        
        #nullable disable
        
    }
}
