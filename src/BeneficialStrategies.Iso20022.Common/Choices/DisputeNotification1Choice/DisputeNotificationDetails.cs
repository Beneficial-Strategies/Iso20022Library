// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DisputeNotification1Choice
{
    /// <summary>
    /// Provides the dispute notification details for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_QmU-M9p-Ed-ak6NoX_4Aeg_-1470616414")]
    [DisplayName("Dispute Notification Details")]
    public partial record DisputeNotificationDetails : DisputeNotification1Choice_
    {
        #nullable enable
        
        /// <summary>
        /// Provides the dispute notification details for the variation margin.
        /// </summary>
        [IsoId("_UllpFdp-Ed-ak6NoX_4Aeg_-641718307")]
        [DisplayName("Variation Margin Dispute")]
        [IsoXmlTag("VartnMrgnDspt")]
        public required VariationMarginDispute1 VariationMarginDispute { get; init; } 
        
        /// <summary>
        /// Provides the dispute notification details for the segregated independent amount.
        /// </summary>
        [IsoId("_UllpFtp-Ed-ak6NoX_4Aeg_1091176533")]
        [DisplayName("Segregated Independent Amount Dispute")]
        [IsoXmlTag("SgrtdIndpdntAmtDspt")]
        public SegregatedIndependentAmountDispute1? SegregatedIndependentAmountDispute { get; init; } 
        
        
        #nullable disable
        
    }
}
