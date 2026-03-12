// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnitOfMeasure6Choice
{
    /// <summary>
    /// Quantity of a product on a line specified by a number. For example, 100 (kgs), 50 (pieces).
    /// </summary>
    [IsoId("_QWXDkfFSEee_LsXdoqzkWg")]
    [DisplayName("Unit Of Measure Code")]
    public partial record UnitOfMeasureCode : UnitOfMeasure6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Identifies the unit of measure by means of a code. The code is taken from UN/ECE Recommendation 20.
        /// </summary>
        [IsoXmlTag("UnitOfMeasrCd")]
        public required UnitOfMeasure9Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
