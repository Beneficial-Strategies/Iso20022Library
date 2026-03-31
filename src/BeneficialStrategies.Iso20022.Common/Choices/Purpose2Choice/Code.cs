// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Purpose2Choice
{
    /// <summary>
    /// Underlying reason for the payment transaction, as published in an external purpose code list.
    /// </summary>
    [IsoId("_P6qyH9p-Ed-ak6NoX_4Aeg_-1283223370")]
    [DisplayName("Code")]
    public record Code : Purpose2Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the external purpose code in the format of character string with a maximum length of 4 characters.
        /// The list of valid codes is an external code list published separately.
        /// External code sets can be downloaded from www.iso20022.org.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ExternalPurpose1Code Value { get; init; }
    }
}
