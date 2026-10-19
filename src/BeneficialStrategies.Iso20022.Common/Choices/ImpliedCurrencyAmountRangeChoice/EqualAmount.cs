// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRangeChoice
{
    /// <summary>
    /// Exact value an amount must match to be considered valid.
    /// </summary>
    [IsoId("_PVH1Adp-Ed-ak6NoX_4Aeg_-1174057054")]
    [DisplayName("Equal Amount")]
    public partial record EqualAmount : ImpliedCurrencyAmountRangeChoice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("EQAmt")]
        public required ImpliedCurrencyAndAmount Value { get; init; }
    }
}
