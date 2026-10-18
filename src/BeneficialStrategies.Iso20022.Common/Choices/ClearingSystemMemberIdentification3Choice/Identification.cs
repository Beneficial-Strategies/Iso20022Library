// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemMemberIdentification3Choice
{
    /// <inheritdoc cref="IIdentification"/>
    [IsoId("_TMehGtp-Ed-ak6NoX_4Aeg_-1564562062")]
    [DisplayName("Identification")]
    public partial record Identification : ClearingSystemMemberIdentification3Choice_
    {
        /// <inheritdoc cref="IIdentification.Value"/>
        [IsoXmlTag("Id")]
        public required ExternalClearingSystemMemberCode Value { get; init; }
    }
}
