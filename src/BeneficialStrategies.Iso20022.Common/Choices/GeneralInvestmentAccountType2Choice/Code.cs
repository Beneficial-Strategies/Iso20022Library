// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.GeneralInvestmentAccountType2Choice
{
    /// <summary>
    /// Type of investment account expressed as a code.
    /// </summary>
    [IsoId("_4Xg9MZNuEembCsVG-3f_AA")]
    [DisplayName("Code")]
    public partial record Code : GeneralInvestmentAccountType2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a type of investment account.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required GeneralInvestmentAccountType2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
