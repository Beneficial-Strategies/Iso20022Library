// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.TaxCalculationBasisType1Choice
{
    /// <summary>
    /// Basis used to determine the capital gain or loss, eg, the purchase price.
    /// </summary>
    [IsoId("_RfQKRtp-Ed-ak6NoX_4Aeg_-1739500184")]
    [DisplayName("Basis")]
    public partial record Basis : TaxCalculationBasisType1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the tax basis.
        /// </summary>
        [IsoXmlTag("Bsis")]
        public required TaxationBasis2Code Value { get; init; } 
        
        
        #nullable disable
        
    }
}
