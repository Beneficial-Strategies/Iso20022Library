// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AccountUsageType2Choice
{
    /// <summary>
    /// Type of account usage expressed as a code.
    /// </summary>
    [IsoId("_LXRysb-FEeWfsa741pI6WA")]
    [DisplayName("Code")]
    public partial record Code : AccountUsageType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of usage of the account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required AccountUsageType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
