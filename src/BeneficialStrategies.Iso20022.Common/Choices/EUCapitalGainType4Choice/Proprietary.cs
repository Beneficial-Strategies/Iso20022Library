// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;

namespace BeneficialStrategies.Iso20022.Choices.EUCapitalGainType4Choice
{
    /// <summary>Extended code to specify whether capital gain is in the scope of the European directive on taxation of savings income.</summary>
    [IsoId("e092bb29-ceb7-46c9-a8f0-c11ccbfa0b21")]
    [DisplayName("Proprietary")]
    public record Proprietary : EUCapitalGainType4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Prtry")]
        public required IsoMax350Text Value { get; init; }
    }
}
