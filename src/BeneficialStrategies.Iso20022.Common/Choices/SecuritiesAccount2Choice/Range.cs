// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.SecuritiesAccount2Choice
{
    /// <summary>One or more securities accounts identified by a range.</summary>
    [IsoId("_4H1_oeGBEeWCAvUNsZ5u6g")]
    [DisplayName("Range")]
    public record Range : SecuritiesAccount2Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Rg")]
        public required SecuritiesAccountRange2 Value { get; init; }
    }
}
