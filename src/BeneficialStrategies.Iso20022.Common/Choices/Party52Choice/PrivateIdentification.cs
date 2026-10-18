// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party52Choice
{
    /// <inheritdoc cref="IPrivateIdentification"/>
    [DisplayName("Private Identification")]
    public partial record PrivateIdentification : Party52Choice_
    {
        /// <inheritdoc cref="IPrivateIdentification.Value"/>
        [IsoXmlTag("PrvtId")]
        public required PersonIdentification18 Value { get; init; }
    }
}
