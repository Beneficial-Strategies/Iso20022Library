// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralMovement3Choice
{
    /// <summary>
    /// Provides the collateral movement direction that is a delivery and optionaly a return.
    /// </summary>
    [IsoId("_QtN1sV9-EeSMgPeFpRHeJw")]
    [DisplayName("Collateral Movement Direction")]
    [IsoXmlTag("CollMvmntDrctn")]
    public record CollateralMovementDirection : CollateralMovement3Choice_
    {
        /// <summary>
        /// Provides the collateral movement direction that is a delivery only.
        /// </summary>
        [IsoId("_RJe68V9-EeSMgPeFpRHeJw")]
        [DisplayName("Deliver")]
        [IsoXmlTag("Dlvr")]
        public required Collateral8 Deliver { get; init; }

        /// <summary>
        /// Provides the collateral movement direction that is a return only.
        /// </summary>
        [IsoId("_RJe6819-EeSMgPeFpRHeJw")]
        [DisplayName("Return")]
        [IsoXmlTag("Rtr")]
        public Collateral7? Return { get; init; }
    }
}
