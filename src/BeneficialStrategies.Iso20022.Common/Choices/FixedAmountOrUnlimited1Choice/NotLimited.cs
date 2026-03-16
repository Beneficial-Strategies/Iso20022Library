// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.FixedAmountOrUnlimited1Choice
{
    /// <summary>
    /// Unlimited amount.
    /// </summary>
    [IsoId("_MA1JsEqBEeKw5sECfP82rg")]
    [DisplayName("Not Limited")]
    public record NotLimited : FixedAmountOrUnlimited1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// String of characters equal to UNLIMITED.
        /// </summary>
        [IsoXmlTag("NotLtd")]
        [IsoSimpleType(IsoSimpleType.Unlimited9Text)]
        public required IsoUnlimited9Text Value { get; init; }
    }
}
