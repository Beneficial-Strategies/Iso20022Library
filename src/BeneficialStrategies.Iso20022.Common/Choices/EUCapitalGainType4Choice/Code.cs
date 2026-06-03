// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.EUCapitalGainType4Choice
{
    /// <summary>ISO 20022 code to specify whether capital gain is in the scope of the European directive on taxation of savings income.</summary>
    [IsoId("fac71824-b8c9-44c6-8689-ff3ed21ab36e")]
    [DisplayName("Code")]
    public record Code : EUCapitalGainType4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Cd")]
        public required EUCapitalGain2Code Value { get; init; }
    }
}
