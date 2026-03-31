// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RepoCallRequestStatus10Choice
{
    /// <summary>
    /// Provides the status of the repurchase agreement call request.
    /// </summary>
    [IsoId("_8Qboi5NLEeWGlc8L7oPDIg")]
    [DisplayName("Code")]
    public record Code : RepoCallRequestStatus10Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies additional information about the status of the repurchase agreement call processed instruction.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required RepoCallRequestStatus1Code Value { get; init; }
    }
}
