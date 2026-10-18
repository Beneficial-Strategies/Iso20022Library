// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ServiceLevel2Choice
{
    /// <inheritdoc cref="ICode"/>
    [IsoId("_QJkwwtp-Ed-ak6NoX_4Aeg_1773004320")]
    [DisplayName("Code")]
    public partial record Code : ServiceLevel2Choice_
    {
        /// <inheritdoc cref="ICode.Value"/>
        [IsoXmlTag("Cd")]
        public required ServiceLevel1Code Value { get; init; }
    }
}
