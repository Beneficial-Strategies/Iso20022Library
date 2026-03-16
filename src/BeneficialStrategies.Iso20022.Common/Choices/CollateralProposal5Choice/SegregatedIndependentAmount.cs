// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralProposal5Choice
{
    /// <summary>
    /// Provides details about the proposal for the segregated independent amount.
    /// </summary>
    [IsoId("_rpS7A4pIEeaNTaanBSMWmg")]
    [DisplayName("Segregated Independent Amount")]
    public record SegregatedIndependentAmount : CollateralProposal5Choice_
    {
        /// <summary>
        /// Provides the call amount that is agreed and that will result in a collateral movement.
        /// </summary>
        [IsoId("_sHMX8YpIEeaNTaanBSMWmg")]
        [DisplayName("Agreed Amount")]
        [IsoXmlTag("AgrdAmt")]
        public required ActiveCurrencyAndAmount AgreedAmount { get; init; }

        /// <summary>
        /// Provides the collateral movement direction that is a delivery and optionally a return, or a return only.
        /// </summary>
        [IsoId("_sHMX84pIEeaNTaanBSMWmg")]
        [DisplayName("Movement Direction")]
        [IsoXmlTag("MvmntDrctn")]
        public CollateralMovement5Choice_? MovementDirection { get; init; }
    }
}
