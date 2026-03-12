// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxableIncomePerShareCalculated2Choice
{
    /// <summary>
    /// Taxable income per share (TIS) calculated expressed as a code.
    /// </summary>
    [IsoId("_wmTxcThgEeamLZQeccJa7w")]
    [DisplayName("Code")]
    public partial record Code : TaxableIncomePerShareCalculated2Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the fund calculates a taxable interest per share (TIS).
        /// </summary>
        [IsoXmlTag("Cd")]
        public required TaxableIncomePerShareCalculated2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
