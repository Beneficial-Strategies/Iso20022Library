// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.ComponentModel.DataAnnotations;
using System.Xml;
using System.Xml.Linq;
using BeneficialStrategies.Iso20022.Components;
using BeneficialStrategies.Iso20022.ExternalSchema;

namespace BeneficialStrategies.Iso20022.Choices.ExecutionType1Choice
{
    /// <summary>
    /// Execution type is executed based on an event driven trigger.
    /// </summary>
    [IsoId("_750BgaMgEeCJ6YNENx4h-w_989331050")]
    [DisplayName("Event")]
    public record Event : ExecutionType1Choice_ { }
}
