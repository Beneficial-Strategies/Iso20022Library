// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Role4Choice
{
    /// <summary>
    /// Role of the party in the activity expressed as a code.
    /// </summary>
    [IsoId("_vrgEwB6YEeOolf0-cMYhrw")]
    [DisplayName("Code")]
    public partial record Code : Role4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the role played by an actor in an investment fund transaction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundRole2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
