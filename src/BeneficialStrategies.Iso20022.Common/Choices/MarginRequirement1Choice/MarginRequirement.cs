// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarginRequirement1Choice
{
    /// <summary>
    /// Provides details about the margin requirements for the variation margin and optionally the segregated independent amount.
    /// </summary>
    [IsoId("_QmogMNp-Ed-ak6NoX_4Aeg_202428352")]
    [DisplayName("Margin Requirement")]
    [IsoXmlTag("MrgnRqrmnt")]
    public record MarginRequirement : MarginRequirement1Choice_
    {
        /// <summary>
        /// Provides details about the margin requirements for the variation margin.
        /// </summary>
        [IsoId("_Ul4kBNp-Ed-ak6NoX_4Aeg_-362986859")]
        [DisplayName("Variation Margin Requirement")]
        [IsoXmlTag("VartnMrgnRqrmnt")]
        public required MarginRequirement1 VariationMarginRequirement { get; init; }

        /// <summary>
        /// Provides details about the margin requirements for the segregated independent amount.
        /// </summary>
        [IsoId("_Ul4kBdp-Ed-ak6NoX_4Aeg_-1666534406")]
        [DisplayName("Segregated Independent Amount Requirement")]
        [IsoXmlTag("SgrtdIndpdntAmtRqrmnt")]
        public MarginRequirement1? SegregatedIndependentAmountRequirement { get; init; }
    }
}
