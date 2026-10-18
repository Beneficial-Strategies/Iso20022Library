// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRange1Choice
{
    /// <summary>
    /// Value that an amount must not match to be considered valid.
    /// </summary>
    [IsoId("_O_mxOZlcEeeE1Ya-LgRsuQ")]
    [DisplayName("Not Equal Amount")]
    public record NotEqualAmount : ImpliedCurrencyAmountRange1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NEQAmt")]
        public required ImpliedCurrencyAndAmount Value { get; init; }
    }
}
