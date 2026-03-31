// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Sets of elements to identify the status of a mandate.
    /// </summary>
    [KnownType(typeof(MandateStatus1Choice.Code))]
    [KnownType(typeof(MandateStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(MandateStatus1Choice.Code), nameof(MandateStatus1Choice.Code))]
    [JsonDerivedType(
        typeof(MandateStatus1Choice.Proprietary),
        nameof(MandateStatus1Choice.Proprietary)
    )]
    [IsoId("_ChH7Y5nAEeao_Z127E9uYg")]
    [DisplayName("Mandate Status 1 Choice")]
    public abstract record MandateStatus1Choice_ { }
}
