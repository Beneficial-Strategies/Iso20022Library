// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.IntraBalanceOrOperationalError11Choice
{
    /// <summary>
    /// Movements.
    /// </summary>
    [DisplayName("Movements")]
    public partial record Movements : IntraBalanceOrOperationalError11Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Mvmnts")]
        public required IntraBalanceMovements4 Value { get; init; } 
        
        
        #nullable disable
        
    }
}
