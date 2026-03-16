// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClearingSystemIdentification2Choice
{
    /// <summary>
    /// Identification of a clearing system, in a coded form as published in an external list.
    /// </summary>
    [IsoId("_TMoSEdp-Ed-ak6NoX_4Aeg_-1410917191")]
    [DisplayName("Code")]
    public record Code : ClearingSystemIdentification2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the clearing system identification code, as published in an external clearing system identification code list.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalClearingSystemIdentification1Code Value { get; init; }
    }
}
