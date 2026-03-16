// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateFormat1Choice
{
    /// <summary>
    /// Date expressed as a code.
    /// </summary>
    [IsoId("_RE37Ztp-Ed-ak6NoX_4Aeg_-1019742655")]
    [DisplayName("Code")]
    public record Code : DateFormat1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Indicates the date of settlement in coded form.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required SettlementDate1Code Value { get; init; }
    }
}
