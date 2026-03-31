// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.RateFormat3Choice
{
    /// <summary>
    /// Value of the rate not specified.
    /// </summary>
    [IsoId("_UPO-mNp-Ed-ak6NoX_4Aeg_681666809")]
    [DisplayName("Not Specified Rate")]
    public record NotSpecifiedRate : RateFormat3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// Specifies the type of rate.
        /// </summary>
        [IsoXmlTag("NotSpcfdRate")]
        public required RateType5Code Value { get; init; }
    }
}
