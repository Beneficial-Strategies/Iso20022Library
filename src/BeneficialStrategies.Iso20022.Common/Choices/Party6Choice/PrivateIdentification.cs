// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party6Choice
{
    /// <summary>
    /// Unique and unambiguous identification of a person, for example a passport.
    /// </summary>
    [IsoId("_Pa7iFtp-Ed-ak6NoX_4Aeg_567091032")]
    [DisplayName("Private Identification")]
    public record PrivateIdentification : Party6Choice_
    {
        /// <summary>
        /// Date and place of birth of a person.
        /// </summary>
        [IsoId("_QENIl9p-Ed-ak6NoX_4Aeg_1634415117")]
        [DisplayName("Date And Place Of Birth")]
        [IsoXmlTag("DtAndPlcOfBirth")]
        public DateAndPlaceOfBirth? DateAndPlaceOfBirth { get; init; }

        /// <summary>
        /// Unique identification of a person, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_QENImNp-Ed-ak6NoX_4Aeg_1634415136")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericPersonIdentification1? Other { get; init; }
    }
}
