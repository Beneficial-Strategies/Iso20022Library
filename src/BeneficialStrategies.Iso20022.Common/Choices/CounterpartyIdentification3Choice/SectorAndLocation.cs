// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyIdentification3Choice
{
    /// <summary>
    /// Identification of the counterparty through the sector and the location.
    /// </summary>
    [IsoId("_ZxnU18EcEea7jLfvGi1PDw")]
    [DisplayName("Sector And Location")]
    public record SectorAndLocation : CounterpartyIdentification3Choice_
    {
        /// <summary>
        /// Represents the counterparty institutional section (such as non-financial corporation, central bank.).
        /// </summary>
        [IsoId("_oLh_0JfdEeSfnc-VXAEapg")]
        [DisplayName("Sector")]
        [IsoXmlTag("Sctr")]
        [IsoSimpleType(IsoSimpleType.SNA2008SectorIdentifier)]
        public required IsoSNA2008SectorIdentifier Sector { get; init; }

        /// <summary>
        /// Location of the country in which the counterparty is incorporated.
        /// </summary>
        [IsoId("_97X68JfeEeSfnc-VXAEapg")]
        [DisplayName("Location")]
        [IsoXmlTag("Lctn")]
        public required CountryCode Location { get; init; }
    }
}
