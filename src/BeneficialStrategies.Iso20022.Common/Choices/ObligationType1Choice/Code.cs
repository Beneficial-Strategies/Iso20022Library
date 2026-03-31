// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ObligationType1Choice
{
    /// <summary>
    /// Indicates the type of the obligation using a code.
    /// </summary>
    [IsoId("_QmCDQNp-Ed-ak6NoX_4Aeg_1786808611")]
    [DisplayName("Code")]
    public record Code : ObligationType1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of the obligation.
        /// </summary>
        [IsoXmlTag("Cd")]
        public required ObligationType1Code Value { get; init; }
    }
}
