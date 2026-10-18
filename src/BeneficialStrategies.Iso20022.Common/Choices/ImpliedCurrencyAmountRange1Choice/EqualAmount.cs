// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ImpliedCurrencyAmountRange1Choice
{
    /// <summary>
    /// Exact value an amount must match to be considered valid.
    /// </summary>
    [IsoId("_O_mxN5lcEeeE1Ya-LgRsuQ")]
    [DisplayName("Equal Amount")]
    public record EqualAmount : ImpliedCurrencyAmountRange1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("EQAmt")]
        public required ImpliedCurrencyAndAmount Value { get; init; }
    }
}
