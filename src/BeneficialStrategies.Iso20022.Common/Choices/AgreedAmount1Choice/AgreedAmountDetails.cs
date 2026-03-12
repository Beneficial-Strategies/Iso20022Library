// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.AgreedAmount1Choice
{
    /// <summary>
    /// Provides details about the agreed amount for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_Qm7bJtp-Ed-ak6NoX_4Aeg_-1292111974")]
    [DisplayName("Agreed Amount Details")]
    public partial record AgreedAmountDetails : AgreedAmount1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides details about the agreed amount for the variation margin.
        /// </summary>
        [IsoId("_UmCVA9p-Ed-ak6NoX_4Aeg_-885757742")]
        [DisplayName("Variation Margin Amount")]
        [IsoXmlTag("VartnMrgnAmt")]
        public required Amount1 VariationMarginAmount { get; init; } 
        
        /// <summary>
        /// Provides details about the agreed amount for the segregated independent amount.
        /// </summary>
        [IsoId("_UmCVBNp-Ed-ak6NoX_4Aeg_-223051895")]
        [DisplayName("Segregated Independent Amount")]
        [IsoXmlTag("SgrtdIndpdntAmt")]
        public Amount1? SegregatedIndependentAmount { get; init; } 
        
        
        #nullable disable
        
    }
}
