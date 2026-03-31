// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RecordMessage1Choice
{
    /// <summary>
    /// Reversal response message record.
    /// </summary>
    [IsoId("_k5mO4FZWEeen1vB4iz5SyA")]
    [DisplayName("Reversal Response")]
    public record ReversalResponse : RecordMessage1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Binary data of 2MB maximum.
        /// </summary>
        [IsoXmlTag("RvslRspn")]
        [IsoSimpleType(IsoSimpleType.Max2MBBinary)]
        public required IsoMax2MBBinary Value { get; init; }
    }
}
