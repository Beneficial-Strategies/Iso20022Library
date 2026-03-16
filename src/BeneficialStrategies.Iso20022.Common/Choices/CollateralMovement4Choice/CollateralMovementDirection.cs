// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralMovement4Choice
{
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionaly a return.
    /// </summary>
    [IsoId("_yckWYYFvEeWtPe6Crjmeug")]
    [DisplayName("Collateral Movement Direction")]
    [IsoXmlTag("CollMvmntDrctn")]
    public record CollateralMovementDirection : CollateralMovement4Choice_
    {
        /// <summary>
        /// Provides the collateral movement direction that is a delivery only.
        /// </summary>
        [IsoId("_yyvasYFvEeWtPe6Crjmeug")]
        [DisplayName("Deliver")]
        [IsoXmlTag("Dlvr")]
        public required Collateral12 Deliver { get; init; }

        /// <summary>
        /// Provides the collateral movement direction that is a return only.
        /// </summary>
        [IsoId("_yyvas4FvEeWtPe6Crjmeug")]
        [DisplayName("Return")]
        [IsoXmlTag("Rtr")]
        public Collateral11? Return { get; init; }
    }
}
