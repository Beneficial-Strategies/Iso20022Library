// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarginTerms1Choice
{
    /// <summary>
    /// Elements used to calculate the collateral margin call for the variation margin and optionally the segregated independent amount.
    /// </summary>
    [IsoId("_QmogM9p-Ed-ak6NoX_4Aeg_-353462081")]
    [DisplayName("Margin Details")]
    public record MarginDetails : MarginTerms1Choice_
    {
        /// <summary>
        /// Elements used to calculate the collateral margin call for the variation margin.
        /// </summary>
        [IsoId("_UnOn1tp-Ed-ak6NoX_4Aeg_-1233189826")]
        [DisplayName("Variation Margin")]
        [IsoXmlTag("VartnMrgn")]
        public required VariationMargin1 VariationMargin { get; init; }

        /// <summary>
        /// Elements used to calculate the collateral margin call for the segregated independent amount.
        /// </summary>
        [IsoId("_UnOn19p-Ed-ak6NoX_4Aeg_1199972462")]
        [DisplayName("Segregated Independent Amount Margin")]
        [IsoXmlTag("SgrtdIndpdntAmtMrgn")]
        public SegregatedIndependentAmountMargin1? SegregatedIndependentAmountMargin { get; init; }
    }
}
