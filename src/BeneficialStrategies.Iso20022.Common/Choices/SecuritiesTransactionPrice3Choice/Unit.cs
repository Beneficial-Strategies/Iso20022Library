// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.SecuritiesTransactionPrice3Choice
{
    /// <summary>
    /// Indicates that price is expressed in units.
    /// </summary>
    [IsoId("_xZbksPdrEeWZFb5ph2Ux9Q")]
    [DisplayName("Unit")]
    public partial record Unit : SecuritiesTransactionPrice3Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, eg, 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.LongDecimalNumber)]
        public required IsoLongDecimalNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
