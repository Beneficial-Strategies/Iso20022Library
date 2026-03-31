// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.Period7Choice
{
    /// <summary>
    /// Time span defined by a start date and time, and an end date and time.
    /// </summary>
    [IsoId("_VQk9UTwGEemGDJYTly2NCA")]
    [DisplayName("From Date Time To Date Time")]
    [IsoXmlTag("FrDtTmToDtTm")]
    public record FromDateTimeToDateTime : Period7Choice_
    {
        /// <summary>
        /// Date and time at which the period starts.
        /// </summary>
        [IsoId("_aeAZNPhvEeSLI7Du5Hk4iw")]
        [DisplayName("From Date Time")]
        [IsoXmlTag("FrDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime FromDateTime { get; init; }

        /// <summary>
        /// Date and time at which the period ends.
        /// </summary>
        [IsoId("_aeAZNfhvEeSLI7Du5Hk4iw")]
        [DisplayName("To Date Time")]
        [IsoXmlTag("ToDtTm")]
        [IsoSimpleType(IsoSimpleType.ISODateTime)]
        public required IsoISODateTime ToDateTime { get; init; }
    }
}
