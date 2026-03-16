// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateTimeSearch2Choice
{
    /// <summary>
    /// Particular time span specified between a start date and an end date.
    /// </summary>
    [IsoId("_7Gq0lX3sEeibM9CPDGCw0g")]
    [DisplayName("From To Date Time")]
    [IsoXmlTag("FrToDtTm")]
    public record FromToDateTime : DateTimeSearch2Choice_
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
