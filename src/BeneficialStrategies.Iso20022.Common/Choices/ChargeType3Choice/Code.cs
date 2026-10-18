// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ChargeType3Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_tjJEUlkyEeGeoaLUQk__nA_-734620698")]
    [DisplayName("Code")]
    public partial record Code : ChargeType3Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ExternalChargeType1Code Value { get; init; }
    }
}
