// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.CounterpartyIdentification2Choice
{
    /// <summary>
    /// Other identification of the counterparty through the sector and the location.
    /// </summary>
    [IsoId("_Qveap3vSEeWrWYBng3OpVw")]
    [DisplayName("Other")]
    [IsoXmlTag("Othr")]
    public record Other : CounterpartyIdentification2Choice_
    {
        /// <summary>
        /// Name or sector of the counterparty of the reporting agent used by the reporting agent.
        /// </summary>
        [IsoId("_ZqzG0YIoEeWA9fc11zJf1Q")]
        [DisplayName("Name Or Sector")]
        [IsoXmlTag("NmOrSctr")]
        public required NameOrSector1Choice_ NameOrSector { get; init; }

        /// <summary>
        /// Location of the country in which the counterparty is incorporated.
        /// </summary>
        [IsoId("_wDEl04InEeWA9fc11zJf1Q")]
        [DisplayName("Location")]
        [IsoXmlTag("Lctn")]
        public required CountryCode Location { get; init; }
    }
}
