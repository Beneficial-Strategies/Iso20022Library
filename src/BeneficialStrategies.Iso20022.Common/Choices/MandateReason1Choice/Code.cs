// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.MandateReason1Choice
{
    /// <summary>
    /// Reason, as published in an external reason code list.
    /// </summary>
    [IsoId("_TOt8xtp-Ed-ak6NoX_4Aeg_193514894")]
    [DisplayName("Code")]
    public record Code : MandateReason1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external mandate processing reason code in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalMandateReason1Code Value { get; init; }
    }
}
