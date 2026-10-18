// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification1Choice
{
    /// <inheritdoc cref="IClearingSystemIdentification"/>
    [IsoId("_TMVXINp-Ed-ak6NoX_4Aeg_-843594927")]
    [DisplayName("Clearing System Identification")]
    public partial record ClearingSystemIdentification : ClearingSystemIdentification1Choice_
    {
        /// <inheritdoc cref="IClearingSystemIdentification.Value"/>
        [IsoXmlTag("ClrSysId")]
        public required CashClearingSystem3Code Value { get; init; }
    }
}
