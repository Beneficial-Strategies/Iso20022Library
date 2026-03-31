// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party36Choice
{
    /// <summary>
    /// Unique and unambiguous identification of a person, eg, passport.
    /// </summary>
    [IsoId("_2uFgE-WkEeevU7McUP3D1w")]
    [DisplayName("Private Identification")]
    [IsoXmlTag("PrvtId")]
    public record PrivateIdentification : Party36Choice_
    {
        /// <summary>
        /// Date and place of birth of a person.
        /// </summary>
        [IsoId("_pYxEw-WkEeevU7McUP3D1w")]
        [DisplayName("Date And Place Of Birth")]
        [IsoXmlTag("DtAndPlcOfBirth")]
        public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; }

        /// <summary>
        /// Unique identification of a person, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_pYxExeWkEeevU7McUP3D1w")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericPersonIdentification1? Other { get; init; }
    }
}
