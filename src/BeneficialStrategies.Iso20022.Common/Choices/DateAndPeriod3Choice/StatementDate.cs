// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateAndPeriod3Choice
{
    /// <summary>
    /// Date of the statement.
    /// </summary>
    [IsoId("_x7SLMQzJEeuTPv2wqaotHg")]
    [DisplayName("Statement Date")]
    public partial record StatementDate : DateAndPeriod3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
