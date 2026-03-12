// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;
using System.Xml;
using System.Xml.Linq;

using System.ComponentModel.DataAnnotations;
namespace BeneficialStrategies.Iso20022.Choices.ExecutionType1Choice
{
    /// <summary>
    /// Execution type is executed based on an event driven trigger.
    /// </summary>
    [IsoId("_750BgaMgEeCJ6YNENx4h-w_989331050")]
    [DisplayName("Event")]
    public partial record Event : ExecutionType1Choice_
    {
        #nullable enable
        
        
        #nullable disable
        
    }
}
