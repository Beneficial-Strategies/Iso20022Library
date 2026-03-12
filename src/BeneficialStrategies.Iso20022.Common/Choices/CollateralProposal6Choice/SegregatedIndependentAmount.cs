// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralProposal6Choice
{
    /// <summary>
    /// Provides details about the proposal for the segregated independent amount.
    /// </summary>
    [IsoId("_5woB4yqREeyR9JrVGfaMKw")]
    [DisplayName("Segregated Independent Amount")]
    public partial record SegregatedIndependentAmount : CollateralProposal6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides the call amount that is agreed and that will result in a collateral movement.
        /// </summary>
        [IsoId("_6IUJISqREeyR9JrVGfaMKw")]
        [DisplayName("Agreed Amount")]
        [IsoXmlTag("AgrdAmt")]
        public required ActiveCurrencyAndAmount AgreedAmount { get; init; } 
        
        /// <summary>
        /// Provides the collateral movement direction that is a delivery and optionally a return, or a return only.
        /// </summary>
        [IsoId("_6IUJIyqREeyR9JrVGfaMKw")]
        [DisplayName("Movement Direction")]
        [IsoXmlTag("MvmntDrctn")]
        public CollateralMovement6Choice_? MovementDirection { get; init; } 
        
        
        #nullable disable
        
    }
}
