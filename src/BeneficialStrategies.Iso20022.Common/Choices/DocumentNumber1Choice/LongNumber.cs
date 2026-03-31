// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DocumentNumber1Choice
{
    /// <summary>
    /// MX Message identifier of the referenced document.
    /// </summary>
    [IsoId("_QzcNKNp-Ed-ak6NoX_4Aeg_-229707560")]
    [DisplayName("Long Number")]
    public record LongNumber : DocumentNumber1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// ISO 20022 Message identifier of an MX message.
        /// </summary>
        [IsoXmlTag("LngNb")]
        [IsoSimpleType(IsoSimpleType.ISO20022MessageIdentificationText)]
        public required IsoISO20022MessageIdentificationText Value { get; init; }
    }
}
