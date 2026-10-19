// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party49Choice
{
    /// <summary>
    /// Unique and unambiguous identification of a person, for example a passport.
    /// </summary>
    [IsoId("_dbeBZeEpEemRzcIkmUETeA")]
    [DisplayName("Private Identification")]
    [IsoXmlTag("PrvtId")]
    public partial record PrivateIdentification : Party49Choice_
    {
        /// <summary>
        /// Date and place of birth of a person.
        /// </summary>
        [IsoId("_dpOwk-EpEemRzcIkmUETeA")]
        [DisplayName("Date And Place Of Birth")]
        [IsoXmlTag("DtAndPlcOfBirth")]
        public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; }

        /// <summary>
        /// Address for electronic mail (e-mail).
        /// </summary>
        [IsoId("_mV-eQeEpEemRzcIkmUETeA")]
        [DisplayName("Email Address")]
        [IsoXmlTag("EmailAdr")]
        [IsoSimpleType(IsoSimpleType.Max256Text)]
        [StringLength(maximumLength: 256, MinimumLength = 1)]
        public Max256Text? EmailAddress { get; init; }

        /// <summary>
        /// Unique identification of a person, as assigned by an institution, using an identification scheme.
        /// </summary>
        [IsoId("_dpOwleEpEemRzcIkmUETeA")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public ValueList<GenericPersonIdentification1> Other { get; init; } = [];
    }
}
