// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CryptographicKey1Choice
{
    /// <inheritdoc cref="IILPV4"/>
    [DisplayName("ILPV4")]
    public partial record ILPV4 : CryptographicKey1Choice_
    {
        /// <inheritdoc cref="IILPV4.Value"/>
        [IsoXmlTag("ILPV4")]
        public required IsoHexBinaryText Value { get; init; }
    }
}
