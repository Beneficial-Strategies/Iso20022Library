// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateFormat1Choice
{
    /// <summary>
    /// Value is not specified.
    /// </summary>
    [IsoId("_UPh5iNp-Ed-ak6NoX_4Aeg_-1534892500")]
    [DisplayName("Not Specified Rate")]
    public partial record NotSpecifiedRate : RateFormat1Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateType12FormatChoice_ Value { get; init; }
    }
}
