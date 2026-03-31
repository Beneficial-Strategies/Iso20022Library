// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ISAPortfolio1Choice
{
    /// <summary>
    /// Wrapper for a specific product or a specific sub-product owned by a set of beneficial owners.
    /// </summary>
    [IsoId("_Ku_xo_pfEeCLMa5EIHtDrg")]
    [DisplayName("Portfolio")]
    public record Portfolio : ISAPortfolio1Choice_
    {
        /// <summary>
        /// Additional information related to the portfolio.
        /// </summary>
        [IsoId("_TU0kwNp-Ed-ak6NoX_4Aeg_501703515")]
        [DisplayName("Portfolio Information")]
        [IsoXmlTag("PrtflInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [MinLength(0)]
        [MaxLength(5)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public SimpleValueList<System.String> PortfolioInformation { get; init; } = [];
    }
}
