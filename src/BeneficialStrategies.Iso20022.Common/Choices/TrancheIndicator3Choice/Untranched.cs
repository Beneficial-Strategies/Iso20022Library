// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TrancheIndicator3Choice
{
    /// <summary>
    /// Indicates that derivative contract is untranched.
    /// </summary>
    [IsoId("_nCVaUw06EeuJ1fOEB4bQXA")]
    [DisplayName("Untranched")]
    public partial record Untranched : TrancheIndicator3Choice_
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
