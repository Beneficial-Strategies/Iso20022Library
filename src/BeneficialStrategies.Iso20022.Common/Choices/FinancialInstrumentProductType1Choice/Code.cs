// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.FinancialInstrumentProductType1Choice
{
    /// <summary>
    /// Identifies the FI product type using a code.
    /// </summary>
    [IsoId("_TvDCoNp-Ed-ak6NoX_4Aeg_-1523417006")]
    [DisplayName("Code")]
    public partial record Code : FinancialInstrumentProductType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of product or financial instrument.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ProductType1Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
