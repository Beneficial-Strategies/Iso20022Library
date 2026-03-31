// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClaimNonReceipt3Choice
{
    /// <summary>
    /// Rejected.
    /// </summary>
    [DisplayName("Rejected")]
    public record Rejected : ClaimNonReceipt3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("Rjctd")]
        public required ClaimNonReceiptRejectReason1Choice_ Value { get; init; }
    }
}
