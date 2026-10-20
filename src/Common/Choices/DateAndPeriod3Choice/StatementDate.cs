// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.DateAndPeriod3Choice
{
    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_x7SLMQzJEeuTPv2wqaotHg")]
    [DisplayName("Statement Date")]
    public partial record StatementDate : DateAndPeriod3Choice_
    {
        /// <summary>Contains the main value for the container.</summary>
        [IsoXmlTag("StmtDt")]
        public required DateAndDateTime2Choice_ Value { get; init; }
    }
}
