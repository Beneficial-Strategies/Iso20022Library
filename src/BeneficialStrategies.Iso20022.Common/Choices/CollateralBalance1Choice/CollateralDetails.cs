// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CollateralBalance1Choice
{
    /// <summary>
    /// Provides details about the collateral held, in transit or that still needs to be agreed by both parties, for the variation margin and optionally the segregated independent amount.
    /// </summary>
    [IsoId("_UnXxydp-Ed-ak6NoX_4Aeg_1050208503")]
    [DisplayName("Collateral Details")]
    public record CollateralDetails : CollateralBalance1Choice_
    {
        /// <summary>
        /// Provides details about the collateral held, in transit or that still needs to be agreed by both parties, against the variation margin.
        /// </summary>
        [IsoId("_Uoa6oNp-Ed-ak6NoX_4Aeg_117230825")]
        [DisplayName("Variation Margin")]
        [IsoXmlTag("VartnMrgn")]
        public required MarginCollateral1 VariationMargin { get; init; }

        /// <summary>
        /// Provides details about the collateral held, in transit or that still needs to be agreed by both parties, against the segregated independent amount.
        /// </summary>
        [IsoId("_Uoa6odp-Ed-ak6NoX_4Aeg_-2144467240")]
        [DisplayName("Segregated Independent Amount")]
        [IsoXmlTag("SgrtdIndpdntAmt")]
        public MarginCollateral1? SegregatedIndependentAmount { get; init; }
    }
}
