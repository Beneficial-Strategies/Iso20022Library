// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the priority.
    /// </summary>
    [KnownType(typeof(PriorityNumeric1Choice.Numeric))]
    [KnownType(typeof(PriorityNumeric1Choice.Proprietary))]
    [JsonDerivedType(typeof(PriorityNumeric1Choice.Numeric),nameof(PriorityNumeric1Choice.Numeric))]
    [JsonDerivedType(typeof(PriorityNumeric1Choice.Proprietary),nameof(PriorityNumeric1Choice.Proprietary))]
    [IsoId("_QuYG8Np-Ed-ak6NoX_4Aeg_827565267")]
    [DisplayName("Priority Numeric 1 Choice")]
    public abstract partial record PriorityNumeric1Choice_
    {
    }
}
