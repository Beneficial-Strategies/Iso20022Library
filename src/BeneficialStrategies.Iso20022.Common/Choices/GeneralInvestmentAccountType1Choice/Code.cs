// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GeneralInvestmentAccountType1Choice
{
    /// <summary>
    /// Type of investment account expressed as a code.
    /// </summary>
    [IsoId("_mog4IF2cEeiFXdiLi_Nf4A")]
    [DisplayName("Code")]
    public partial record Code : GeneralInvestmentAccountType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of investment account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GeneralInvestmentAccountType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
