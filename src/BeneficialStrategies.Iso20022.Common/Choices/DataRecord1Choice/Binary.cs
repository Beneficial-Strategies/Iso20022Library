// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DataRecord1Choice
{
    /// <summary>
    /// Contains the data record in Binary format.
    /// </summary>
    [IsoId("_hWEYMJb8Eeuc6pwKtqbEVQ")]
    [DisplayName("Binary")]
    public record Binary : DataRecord1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Binary data of 20 megabytes (20 Mb) maximum.
        /// </summary>
        [IsoXmlTag("Binry")]
        [IsoSimpleType(IsoSimpleType.Max20MbBinary)]
        public required IsoMax20MbBinary Value { get; init; }
    }
}
