// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.TrackerParty2Choice
{
    /// <summary>
    /// Unique and unambiguous identification of a person, for example a passport.
    /// </summary>
    [IsoId("_dtxoxWOTEeq5Ar_w98FvsA")]
    [DisplayName("Private Identification")]
    [IsoXmlTag("PrvtId")]
    public record PrivateIdentification : TrackerParty2Choice_
    {
        /// <summary>
        /// Date and place of birth of a person.
        /// </summary>
        [IsoId("_jU7hA69UEeeJJK1oRb-jTw")]
        [DisplayName("Date And Place Of Birth")]
        [IsoXmlTag("DtAndPlcOfBirth")]
        public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; }

        /// <summary>
        /// Unique identification of a person, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_jU7hBa9UEeeJJK1oRb-jTw")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericPersonIdentification1? Other { get; init; }
    }
}
