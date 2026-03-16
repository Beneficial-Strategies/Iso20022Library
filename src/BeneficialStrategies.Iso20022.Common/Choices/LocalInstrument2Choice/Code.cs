// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LocalInstrument2Choice
{
    /// <summary>
    /// Specifies the local instrument, as published in an external local instrument code list.
    /// </summary>
    [IsoId("_TF7NI9p-Ed-ak6NoX_4Aeg_365018928")]
    [DisplayName("Code")]
    public record Code : LocalInstrument2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external local instrument code in the format of character string with a maximum length of 35 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalLocalInstrument1Code Value { get; init; }
    }
}
