// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References80Choice
{
    /// <inheritdoc cref="IPoolIdentification"/>
    [DisplayName("Pool Identification")]
    public partial record PoolIdentification : References80Choice_
    {
        /// <inheritdoc cref="IPoolIdentification.Value"/>
        [IsoXmlTag("PoolId")]
        public required IsoMax35Text Value { get; init; }
    }
}
