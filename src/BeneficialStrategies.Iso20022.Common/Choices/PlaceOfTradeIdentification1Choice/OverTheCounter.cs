// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.PlaceOfTradeIdentification1Choice
{
    /// <summary>
    /// Place at which the Over-the-Counter (OTC) transaction is executed.
    /// </summary>
    [IsoId("_TCfeo9p-Ed-ak6NoX_4Aeg_-307445135")]
    [DisplayName("Over The Counter")]
    public record OverTheCounter : PlaceOfTradeIdentification1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 35 characters.
        /// </summary>
        [IsoXmlTag("OverTheCntr")]
        [IsoSimpleType(IsoSimpleType.Max35Text)]
        [StringLength(maximumLength: 35, MinimumLength = 1)]
        public required IsoMax35Text Value { get; init; }
    }
}
