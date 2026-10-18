// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Frequency21Choice
{
    /// <inheritdoc cref="IType"/>
    [IsoId("_6GkgAR7yEeSxevWRRWxNAg")]
    [DisplayName("Type")]
    public partial record Type : Frequency21Choice_
    {
        /// <inheritdoc cref="IType.Value"/>
        [IsoXmlTag("Tp")]
        public required Frequency6Code Value { get; init; }
    }
}
