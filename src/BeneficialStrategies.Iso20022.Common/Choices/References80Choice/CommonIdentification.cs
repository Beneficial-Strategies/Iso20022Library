// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.References80Choice
{
    /// <inheritdoc cref="ICommonIdentification"/>
    [DisplayName("Common Identification")]
    public partial record CommonIdentification : References80Choice_
    {
        /// <inheritdoc cref="ICommonIdentification.Value"/>
        [IsoXmlTag("CmonId")]
        public required IsoMax35Text Value { get; init; }
    }
}
