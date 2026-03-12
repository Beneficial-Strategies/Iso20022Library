// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.InvestmentFundPlanType1Choice
{
    /// <summary>
    /// Type of investment fund plan expressed as a code.
    /// </summary>
    [IsoId("_aQLGsF9CEeicg40_9gK9vQ")]
    [DisplayName("Code")]
    public partial record Code : InvestmentFundPlanType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of investment fund plan.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundPlanType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
