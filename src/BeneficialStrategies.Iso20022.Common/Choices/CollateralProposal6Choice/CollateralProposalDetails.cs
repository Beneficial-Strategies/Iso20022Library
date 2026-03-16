// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralProposal6Choice
{
    /// <summary>
    /// Provides details about the proposal for the variation margin and optionally the segregated independent amount.
    /// </summary>
    [IsoId("_5woB4SqREeyR9JrVGfaMKw")]
    [DisplayName("Collateral Proposal Details")]
    [IsoXmlTag("CollPrpslDtls")]
    public record CollateralProposalDetails : CollateralProposal6Choice_
    {
        /// <summary>
        /// Provides details about the proposal for the variation margin.
        /// </summary>
        [IsoId("_8XqVkSqREeyR9JrVGfaMKw")]
        [DisplayName("Variation Margin")]
        [IsoXmlTag("VartnMrgn")]
        public required CollateralMovement12 VariationMargin { get; init; }

        /// <summary>
        /// Provides details about the proposal for the segregated independent amount.
        /// </summary>
        [IsoId("_8XqVkyqREeyR9JrVGfaMKw")]
        [DisplayName("Segregated Independent Amount")]
        [IsoXmlTag("SgrtdIndpdntAmt")]
        public CollateralMovement12? SegregatedIndependentAmount { get; init; }
    }
}
