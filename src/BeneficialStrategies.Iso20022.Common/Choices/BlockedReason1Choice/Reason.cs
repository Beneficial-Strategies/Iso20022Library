// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.BlockedReason1Choice
{
    /// <summary>
    /// Reason expressed as a code.
    /// </summary>
    [IsoId("_rKbmwBHdEeKVqeHljBM1MQ")]
    [DisplayName("Reason")]
    public record Reason : BlockedReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the reason an account is blocked.
        /// </summary>
        [IsoXmlTag("Rsn")]
        public required BlockedReason1Code Value { get; init; }
    }
}
