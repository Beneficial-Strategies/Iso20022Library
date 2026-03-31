// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarginRequirement1Choice
{
    /// <summary>
    /// Provides details about the margin requirements for the segregated independent amount only.
    /// </summary>
    [IsoId("_QmogMdp-Ed-ak6NoX_4Aeg_-911647050")]
    [DisplayName("Segregated Independent Amount Requirement")]
    [IsoXmlTag("SgrtdIndpdntAmtRqrmnt")]
    public record SegregatedIndependentAmountRequirement : MarginRequirement1Choice_
    {
        /// <summary>
        /// Amount of new margin that will be delivered to one party by the other party after rounding, threshold and minimum transfer amount are taken into account.
        /// </summary>
        [IsoId("_Ul4kAdp-Ed-ak6NoX_4Aeg_1961004215")]
        [DisplayName("Deliver Margin Amount")]
        [IsoXmlTag("DlvrMrgnAmt")]
        public ActiveCurrencyAndAmount? DeliverMarginAmount { get; init; }

        /// <summary>
        /// Amount of new margin that will be recalled to one party from the other party after rounding, threshold and minimum transfer amount are taken into account.
        /// </summary>
        [IsoId("_Ul4kAtp-Ed-ak6NoX_4Aeg_-1890638845")]
        [DisplayName("Return Margin Amount")]
        [IsoXmlTag("RtrMrgnAmt")]
        public ActiveCurrencyAndAmount? ReturnMarginAmount { get; init; }
    }
}
