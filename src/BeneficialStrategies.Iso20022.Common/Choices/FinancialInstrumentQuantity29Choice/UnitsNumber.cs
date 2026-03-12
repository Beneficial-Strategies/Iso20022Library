// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity29Choice
{
    /// <summary>
    /// Number of investment fund units redeemed.
    /// </summary>
    [IsoId("_52gvY0_3Eea1ZIrmU5dI3w")]
    [DisplayName("Units Number")]
    public partial record UnitsNumber : FinancialInstrumentQuantity29Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Number of objects represented as a decimal number, for example 0.75 or 45.6.
        /// </summary>
        [IsoXmlTag("UnitsNb")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Value { get; init; } 
        
        
        #nullable disable
        
    }
}
