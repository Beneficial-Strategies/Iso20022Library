// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ChargeBasis2Choice
{
    /// <summary>
    /// Fee (charge/commission) basis expressed as a code.
    /// </summary>
    [IsoId("_9tIUYjh5EeaH-93K5JKmzw")]
    [DisplayName("Code")]
    public partial record Code : ChargeBasis2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the tax or charge basis.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxationBasis5Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
