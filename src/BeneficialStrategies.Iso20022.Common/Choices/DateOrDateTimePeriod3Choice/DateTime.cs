// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateOrDateTimePeriod3Choice
{
    /// <summary>
    /// Period expressed a dates and times.
    /// </summary>
    [IsoId("_Fk5tlP1bEeiAfJEqh4xF_Q")]
    [DisplayName("Date Time")]
    public partial record DateTime : DateOrDateTimePeriod3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("DtTm")]
        public required Period8Choice_ Value { get; init; }
    }
}
