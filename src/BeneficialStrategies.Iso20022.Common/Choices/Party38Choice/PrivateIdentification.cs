// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Party38Choice
{
    /// <inheritdoc cref="IPrivateIdentification"/>
    [IsoId("_6VWvRW48EeiU9cctagi5ow")]
    [DisplayName("Private Identification")]
    [IsoXmlTag("PrvtId")]
    public partial record PrivateIdentification : Party38Choice_
    {
        /// <inheritdoc cref="IPrivateIdentification.DateAndPlaceOfBirth"/>
        [IsoId("_jU7hA69UEeeJJK1oRb-jTw")]
        [DisplayName("Date And Place Of Birth")]
        [IsoXmlTag("DtAndPlcOfBirth")]
        public DateAndPlaceOfBirth1? DateAndPlaceOfBirth { get; init; }

        /// <inheritdoc cref="IPrivateIdentification.Other"/>
        [IsoId("_jU7hBa9UEeeJJK1oRb-jTw")]
        [DisplayName("Other")]
        [IsoXmlTag("Othr")]
        public GenericPersonIdentification1? Other { get; init; }
    }
}
