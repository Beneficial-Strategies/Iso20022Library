// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepoCallRequestStatus8Choice
{
    /// <summary>
    /// Provides the status of the repurchase agreement call request.
    /// </summary>
    [IsoId("_IRR7sTqqEeWyoP0PbocV1Q")]
    [DisplayName("Code")]
    public record Code : RepoCallRequestStatus8Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies additional information about the status of the repurchase agreement call processed instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RepoCallRequestStatus1Code Value { get; init; }
    }
}
