// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.CollateralProposalResponse1Choice
{
    /// <summary>
    /// Provides the collateral proposal response for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_QmU-Ntp-Ed-ak6NoX_4Aeg_-930993796")]
    [DisplayName("Collateral Proposal Details")]
    public partial record CollateralProposalDetails : CollateralProposalResponse1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides the collateral proposal response for the variation margin.
        /// </summary>
        [IsoId("_Un-OsNp-Ed-ak6NoX_4Aeg_1523875178")]
        [DisplayName("Variation Margin")]
        [IsoXmlTag("VartnMrgn")]
        public required CollateralProposalResponseType1 VariationMargin { get; init; } 
        
        /// <summary>
        /// Provides the collateral proposal response for the segregated independent amount.
        /// </summary>
        [IsoId("_Un-Osdp-Ed-ak6NoX_4Aeg_495998961")]
        [DisplayName("Segregated Independent Amount")]
        [IsoXmlTag("SgrtdIndpdntAmt")]
        public CollateralProposalResponseType1? SegregatedIndependentAmount { get; init; } 
        
        
        #nullable disable
        
    }
}
