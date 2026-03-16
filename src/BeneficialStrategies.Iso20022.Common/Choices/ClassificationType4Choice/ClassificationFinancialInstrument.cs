// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ClassificationType4Choice
{
    /// <summary>
    /// ISO 10962 Classification of Financial Instrument (CFI).
    /// </summary>
    [IsoId("_XQgXM9p-Ed-ak6NoX_4Aeg_-788391971")]
    [DisplayName("Classification Financial Instrument")]
    public record ClassificationFinancialInstrument : ClassificationType4Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Classification type of the financial instrument, as per the ISO 10962 Classification of Financial Instrument (CFI) codification, eg, common share with voting rights, fully paid, or registered.
        /// </summary>
        [IsoXmlTag("ClssfctnFinInstrm")]
        [IsoSimpleType(IsoSimpleType.CFIIdentifier)]
        public required IsoCFIIdentifier Value { get; init; }
    }
}
