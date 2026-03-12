// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralMovement6Choice
{
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionally a return.
    /// </summary>
    [IsoId("_6gAQYSqREeyR9JrVGfaMKw")]
    [DisplayName("Collateral Movement Direction")]
    public partial record CollateralMovementDirection : CollateralMovement6Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides the collateral movement direction that is a delivery only.
        /// </summary>
        [IsoId("_7nrqISqREeyR9JrVGfaMKw")]
        [DisplayName("Deliver")]
        [IsoXmlTag("Dlvr")]
        public required Collateral55 Deliver { get; init; } 
        
        /// <summary>
        /// Provides the collateral movement direction that is a return only.
        /// </summary>
        [IsoId("_7nrqIyqREeyR9JrVGfaMKw")]
        [DisplayName("Return")]
        [IsoXmlTag("Rtr")]
        public Collateral54? Return { get; init; } 
        
        
        #nullable disable
        
    }
}
