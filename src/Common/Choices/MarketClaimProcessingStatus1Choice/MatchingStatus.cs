// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MarketClaimProcessingStatus1Choice
{
    /// <summary>
    /// Provides the matching status of the instruction.
    /// </summary>
    [IsoId("_ApI08RUIEeuZw7VHHgrHLg")]
    [DisplayName("Matching Status")]
    public partial record MatchingStatus : MarketClaimProcessingStatus1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("MtchgSts")]
        public required MatchingStatus34Choice_ Value { get; init; }
    }
}
