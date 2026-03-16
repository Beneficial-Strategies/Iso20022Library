// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.VoteThroughNetwork1Choice
{
    /// <summary>
    /// Voting is performed by sending a vote message directly to the issuer.
    /// </summary>
    [IsoId("_LM16IDT8Ee2tRf29bleifQ")]
    [DisplayName("Vote Directly To Issuer")]
    public record VoteDirectlyToIssuer : VoteThroughNetwork1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code allocated to a financial or non-financial institution by the ISO 9362 Registration Authority, as described in ISO 9362: 2014 - &quot;Banking - Banking telecommunication messages - Business identifier code (BIC)&quot;.
        /// </summary>
        [IsoXmlTag("VoteDrctlyToIssr")]
        [IsoSimpleType(IsoSimpleType.AnyBICDec2014Identifier)]
        public required IsoAnyBICDec2014Identifier Value { get; init; }
    }
}
