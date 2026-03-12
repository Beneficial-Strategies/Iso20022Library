// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.Role6Choice
{
    /// <summary>
    /// Role of the party in the activity expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_exy38Tm9EeWV5sr121Fc8A")]
    [DisplayName("Code")]
    public partial record Code : Role6Choice_
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
