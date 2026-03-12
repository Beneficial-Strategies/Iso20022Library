// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.UnitOrFaceAmountOrCodeChoice
{
    /// <summary>
    /// Quantity expressed as a code.
    /// </summary>
    [IsoId("_Sokix9p-Ed-ak6NoX_4Aeg_1237941764")]
    [DisplayName("Code")]
    public partial record Code : UnitOrFaceAmountOrCodeChoice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies quantity of a financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required Quantity1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
