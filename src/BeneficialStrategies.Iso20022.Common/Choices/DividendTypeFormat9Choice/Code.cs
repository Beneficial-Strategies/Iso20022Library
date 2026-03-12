// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DividendTypeFormat9Choice
{
    /// <summary>
    /// Standard code to specify the frequency of the corporate action event.
    /// </summary>
    [IsoId("_yEjjE0EFEeWVgfuHGaKtRQ")]
    [DisplayName("Code")]
    public partial record Code : DividendTypeFormat9Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Automatic Reinvestment of Cash distributed by accumulating funds.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionFrequencyType5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
