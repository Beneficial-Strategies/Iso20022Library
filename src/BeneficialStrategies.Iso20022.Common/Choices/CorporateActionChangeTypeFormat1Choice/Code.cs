// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CorporateActionChangeTypeFormat1Choice
{
    /// <summary>
    /// Standard code to specify the type of changes.
    /// </summary>
    [IsoId("_Q3Unltp-Ed-ak6NoX_4Aeg_941345591")]
    [DisplayName("Code")]
    public record Code : CorporateActionChangeTypeFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of changes.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required CorporateActionChangeType1Code Value { get; init; }
    }
}
