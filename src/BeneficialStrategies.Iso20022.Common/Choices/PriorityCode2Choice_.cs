// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Priority is expressed as a code or a text.
    /// </summary>
    [KnownType(typeof(PriorityCode2Choice.Code))]
    [KnownType(typeof(PriorityCode2Choice.Proprietary))]
    [JsonDerivedType(typeof(PriorityCode2Choice.Code),nameof(PriorityCode2Choice.Code))]
    [JsonDerivedType(typeof(PriorityCode2Choice.Proprietary),nameof(PriorityCode2Choice.Proprietary))]
    [IsoId("_74UMsqMgEeCJ6YNENx4h-w_784788398")]
    [DisplayName("Priority Code 2 Choice")]
    public abstract partial record PriorityCode2Choice_
    {
    }
}
