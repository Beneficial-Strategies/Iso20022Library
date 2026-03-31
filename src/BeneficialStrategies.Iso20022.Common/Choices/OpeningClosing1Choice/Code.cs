// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.OpeningClosing1Choice
{
    /// <summary>
    /// Opening closing information expressed as an ISO 20022 code.
    /// </summary>
    [IsoId("_Qs45Ntp-Ed-ak6NoX_4Aeg_-535347217")]
    [DisplayName("Code")]
    public record Code : OpeningClosing1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies additional information relative to the processing of the trade.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required OpeningClosing1Code Value { get; init; }
    }
}
