// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentQuantity10Choice
{
    /// <summary>
    /// Total quantity of units to be redeemed.
    /// </summary>
    [IsoId("_RgmOGNp-Ed-ak6NoX_4Aeg_2104922780")]
    [DisplayName("Units Number")]
    public partial record UnitsNumber : FinancialInstrumentQuantity10Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Quantity expressed as a number, eg, a number of shares.
        /// </summary>
        [IsoId("_SoH21dp-Ed-ak6NoX_4Aeg_-1748202212")]
        [DisplayName("Unit")]
        [IsoXmlTag("Unit")]
        [IsoSimpleType(IsoSimpleType.DecimalNumber)]
        public required IsoDecimalNumber Unit { get; init; } 
        
        
        #nullable disable
        
    }
}
