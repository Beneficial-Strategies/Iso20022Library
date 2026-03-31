// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.LimitStructure3Choice
{
    /// <summary>
    /// All Current Limits.
    /// </summary>
    [DisplayName("All Current Limits")]
    public record AllCurrentLimits : LimitStructure3Choice_
    {
        /// <summary>
        /// Contains the main value for the container.
        /// </summary>
        [IsoXmlTag("AllCurLmts")]
        public required LimitIdentification9 Value { get; init; }
    }
}
