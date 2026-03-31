// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarginCallResult2Choice
{
    /// <summary>
    /// Provides the summation of the call amounts for the variation margin and optionaly the segregated independent amount.
    /// </summary>
    [IsoId("_9boCQKMPEeCojJW5vEuTEQ_1384684121")]
    [DisplayName("Margin Call Result Details")]
    [IsoXmlTag("MrgnCallRsltDtls")]
    public record MarginCallResultDetails : MarginCallResult2Choice_
    {
        /// <summary>
        /// Provides the summation of the call amounts for the variation margin amount only.
        /// </summary>
        [IsoId("_UlvaF9p-Ed-ak6NoX_4Aeg_-1196189794")]
        [DisplayName("Variation Margin Result")]
        [IsoXmlTag("VartnMrgnRslt")]
        public required Result1 VariationMarginResult { get; init; }

        /// <summary>
        /// Provides the summation of the call amounts for the segregated independent amount.
        /// </summary>
        [IsoId("_UlvaGNp-Ed-ak6NoX_4Aeg_872246105")]
        [DisplayName("Segregated Independent Amount")]
        [IsoXmlTag("SgrtdIndpdntAmt")]
        public Result1? SegregatedIndependentAmount { get; init; }
    }
}
