// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExpectedCollateral1Choice
{
    /// <summary>
    /// Provides the expected collateral type and direction for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_QmevM9p-Ed-ak6NoX_4Aeg_-1089909522")]
    [DisplayName("Expected Collateral Details")]
    [IsoXmlTag("XpctdCollDtls")]
    public record ExpectedCollateralDetails : ExpectedCollateral1Choice_
    {
        /// <summary>
        /// Provides the expected collateral type and direction for the variation margin.
        /// </summary>
        [IsoId("_UlvaENp-Ed-ak6NoX_4Aeg_259803372")]
        [DisplayName("Variation Margin")]
        [IsoXmlTag("VartnMrgn")]
        public required ExpectedCollateralMovement1 VariationMargin { get; init; }

        /// <summary>
        /// Provides the expected collateral type and direction for the segregated independent amount.
        /// </summary>
        [IsoId("_UlvaEdp-Ed-ak6NoX_4Aeg_-964605282")]
        [DisplayName("Segregated Independent Amount")]
        [IsoXmlTag("SgrtdIndpdntAmt")]
        public ExpectedCollateralMovement1? SegregatedIndependentAmount { get; init; }
    }
}
