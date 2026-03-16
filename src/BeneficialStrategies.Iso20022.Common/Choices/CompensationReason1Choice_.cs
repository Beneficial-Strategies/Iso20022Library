// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the payment compensation.
    /// </summary>
    [KnownType(typeof(CompensationReason1Choice.Code))]
    [KnownType(typeof(CompensationReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CompensationReason1Choice.Code),
        nameof(CompensationReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CompensationReason1Choice.Proprietary),
        nameof(CompensationReason1Choice.Proprietary)
    )]
    [IsoId("_UyHYkIjYEeeDW7_wB-eK_g")]
    [DisplayName("Compensation Reason 1 Choice")]
    public abstract record CompensationReason1Choice_ { }
}
