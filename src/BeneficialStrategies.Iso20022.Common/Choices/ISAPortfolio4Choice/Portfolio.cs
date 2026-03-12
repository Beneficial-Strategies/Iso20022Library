// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ISAPortfolio4Choice
{
    /// <summary>
    /// Wrapper for a specific product or a specific sub-product owned by a set of beneficial owners.
    /// </summary>
    [IsoId("_1AA5A7NBEeewUI7-Tnew9A")]
    [DisplayName("Portfolio")]
    public partial record Portfolio : ISAPortfolio4Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Additional information related to the portfolio.
        /// </summary>
        [IsoId("_TU0kwNp-Ed-ak6NoX_4Aeg_501703515")]
        [DisplayName("Portfolio Information")]
        [IsoXmlTag("PrtflInf")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [MinLength(0)]
        [MaxLength(5)]
        [StringLength(maximumLength: 350 ,MinimumLength = 1)]
        public SimpleValueList<System.String> PortfolioInformation { get; init; } = new SimpleValueList<System.String>(){};
        
        
        #nullable disable
        
    }
}
