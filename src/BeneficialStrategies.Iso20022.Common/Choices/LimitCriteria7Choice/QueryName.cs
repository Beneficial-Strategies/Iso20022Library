// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LimitCriteria7Choice
{
    /// <summary>
    /// Query Name.
    /// </summary>
    [DisplayName("Query Name")]
    public record QueryName : LimitCriteria7Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("QryNm")]
        public required IsoMax35Text Value { get; init; }
    }
}
