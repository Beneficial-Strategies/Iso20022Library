// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRangeChoice
{
    /// <summary>
    /// Value that an amount must not match to be considered valid.
    /// </summary>
    [IsoId("_PVH1Atp-Ed-ak6NoX_4Aeg_-1093710164")]
    [DisplayName("Not Equal Amount")]
    public partial record NotEqualAmount : ImpliedCurrencyAmountRangeChoice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NEQAmt")]
        public required ImpliedCurrencyAndAmount Value { get; init; }
    }
}
