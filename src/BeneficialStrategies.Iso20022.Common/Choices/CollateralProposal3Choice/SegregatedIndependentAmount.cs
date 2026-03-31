// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralProposal3Choice
{
    /// <summary>
    /// Provides details about the proposal for the segregated independent amount.
    /// </summary>
    [IsoId("_P0F1U19-EeSMgPeFpRHeJw")]
    [DisplayName("Segregated Independent Amount")]
    [IsoXmlTag("SgrtdIndpdntAmt")]
    public record SegregatedIndependentAmount : CollateralProposal3Choice_
    {
        /// <summary>
        /// Provides the call amount that is agreed and that will result in a collateral movement.
        /// </summary>
        [IsoId("_QQNJkV9-EeSMgPeFpRHeJw")]
        [DisplayName("Agreed Amount")]
        [IsoXmlTag("AgrdAmt")]
        public required ActiveCurrencyAndAmount AgreedAmount { get; init; }

        /// <summary>
        /// Provides the collateral movement direction that is a delivery and optionaly a return, or a return only.
        /// </summary>
        [IsoId("_QQNJk19-EeSMgPeFpRHeJw")]
        [DisplayName("Movement Direction")]
        [IsoXmlTag("MvmntDrctn")]
        public CollateralMovement3Choice_? MovementDirection { get; init; }
    }
}
