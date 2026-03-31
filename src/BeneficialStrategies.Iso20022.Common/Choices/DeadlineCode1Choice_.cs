// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a proprietary code for a deadline code.
    /// </summary>
    [KnownType(typeof(DeadlineCode1Choice.Code))]
    [KnownType(typeof(DeadlineCode1Choice.Proprietary))]
    [JsonDerivedType(typeof(DeadlineCode1Choice.Code), nameof(DeadlineCode1Choice.Code))]
    [JsonDerivedType(
        typeof(DeadlineCode1Choice.Proprietary),
        nameof(DeadlineCode1Choice.Proprietary)
    )]
    [IsoId("_Q0L0CNp-Ed-ak6NoX_4Aeg_1003378554")]
    [DisplayName("Deadline Code 1 Choice")]
    public abstract record DeadlineCode1Choice_ { }
}
