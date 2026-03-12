// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.DateAndPeriod3Choice
{
    /// <summary>
    /// Period for the statement.
    /// </summary>
    [IsoId("_x7SLOQzJEeuTPv2wqaotHg")]
    [DisplayName("Statement Period")]
    public partial record StatementPeriod : DateAndPeriod3Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
