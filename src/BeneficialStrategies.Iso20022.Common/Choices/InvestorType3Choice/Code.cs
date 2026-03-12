// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestorType3Choice
{
    /// <summary>
    /// Investor type expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_c8LMUeLxEeWOD7aAy2fAcA")]
    [DisplayName("Code")]
    public partial record Code : InvestorType3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of investor.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestorType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
