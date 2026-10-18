// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferStatus4Choice
{
    /// <summary>
    /// Status of the transfer is unmatched.
    /// </summary>
    [IsoId("_fmnCdZM5EemKz5EOjv82iQ")]
    [DisplayName("Unmatched")]
    public partial record Unmatched : TransferStatus4Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("Umtchd")]
        public required TransferUnmatchedStatus4Choice_ Value { get; init; }
    }
}
