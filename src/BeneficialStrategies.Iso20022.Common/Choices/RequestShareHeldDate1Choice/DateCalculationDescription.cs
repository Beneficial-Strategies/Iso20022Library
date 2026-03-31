// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RequestShareHeldDate1Choice
{
    /// <summary>
    /// Provides the description on how the date from which the shares have been held should be determined and communicated.
    /// </summary>
    [IsoId("_3b5pQFSTEempisJfoIfvvQ")]
    [DisplayName("Date Calculation Description")]
    public record DateCalculationDescription : RequestShareHeldDate1Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies a character string with a maximum length of 350 characters.
        /// </summary>
        [IsoXmlTag("DtClctnDesc")]
        [IsoSimpleType(IsoSimpleType.Max350Text)]
        [StringLength(maximumLength: 350, MinimumLength = 1)]
        public required IsoMax350Text Value { get; init; }
    }
}
