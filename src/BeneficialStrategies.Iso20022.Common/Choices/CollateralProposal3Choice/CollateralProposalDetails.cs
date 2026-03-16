// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralProposal3Choice
{
    /// <summary>
    /// Provides details about the proposal for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_P0F1UV9-EeSMgPeFpRHeJw")]
    [DisplayName("Collateral Proposal Details")]
    public record CollateralProposalDetails : CollateralProposal3Choice_
    {
        /// <summary>
        /// Provides details about the proposal for the variation margin.
        /// </summary>
        [IsoId("_RmfnEV9-EeSMgPeFpRHeJw")]
        [DisplayName("Variation Margin")]
        [IsoXmlTag("VartnMrgn")]
        public required CollateralMovement5 VariationMargin { get; init; }

        /// <summary>
        /// Provides details about the proposal for the segregated independent amount.
        /// </summary>
        [IsoId("_RmfnE19-EeSMgPeFpRHeJw")]
        [DisplayName("Segregated Independent Amount")]
        [IsoXmlTag("SgrtdIndpdntAmt")]
        public CollateralMovement5? SegregatedIndependentAmount { get; init; }
    }
}
