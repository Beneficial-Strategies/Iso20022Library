// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargeType5Choice
{
    /// <summary>
    /// Fee (charge/commission) expressed as a code.
    /// </summary>
    [IsoId("_-Oqwojh4EeaH-93K5JKmzw")]
    [DisplayName("Code")]
    public partial record Code : ChargeType5Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of service for which a fee e is asked or paid.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required InvestmentFundFee1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
