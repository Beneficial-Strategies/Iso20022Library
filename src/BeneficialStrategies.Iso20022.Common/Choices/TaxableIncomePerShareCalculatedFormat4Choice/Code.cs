// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxableIncomePerShareCalculatedFormat4Choice
{
    /// <summary>
    /// Standard code to specify whether the fund calculates the taxable income per dividend/taxable income per share (TID/TIS).
    /// </summary>
    [IsoId("_c5WhFZKQEeWHWpTQn1FFVg")]
    [DisplayName("Code")]
    public partial record Code : TaxableIncomePerShareCalculatedFormat4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the fund calculates the taxable income per dividend/taxable income per share (TID/TIS).
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionTaxableIncomePerShareCalculated1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
