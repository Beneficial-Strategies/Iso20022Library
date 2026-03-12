// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxableIncomePerShareCalculatedType1Choice
{
    /// <summary>
    /// Specifies whether the fund calculates a taxable interest per share (TIS).
    /// </summary>
    [IsoId("_RfQKQ9p-Ed-ak6NoX_4Aeg_1712163879")]
    [DisplayName("Taxable Income Per Share Calculated")]
    public partial record TaxableIncomePerShareCalculated : TaxableIncomePerShareCalculatedType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies whether the fund calculates a taxable interest per share (TIS).
        /// </summary>
        [IsoXmlTag("TaxblIncmPerShrClctd")]
        public required TaxableIncomePerShareCalculated2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
