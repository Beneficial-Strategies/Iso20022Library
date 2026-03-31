// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TransferUnmatchedStatus4Choice
{
    /// <summary>
    /// Reason for the unmatched status.
    /// </summary>
    [IsoId("_k75sJZM5EemKz5EOjv82iQ")]
    [DisplayName("Extended Reason")]
    public record ExtendedReason : TransferUnmatchedStatus4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Code and / or description for values that are not yet part of the related code list.
        /// </summary>
        [IsoXmlTag("XtndedRsn")]
        [IsoSimpleType(IsoSimpleType.Extended350Code)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoExtended350Code Value { get; init; }
    }
}
