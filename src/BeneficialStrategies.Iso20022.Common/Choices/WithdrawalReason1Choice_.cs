// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a withdrawal reason.
    /// </summary>
    [KnownType(typeof(WithdrawalReason1Choice.Code))]
    [KnownType(typeof(WithdrawalReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(WithdrawalReason1Choice.Code), nameof(WithdrawalReason1Choice.Code))]
    [JsonDerivedType(
        typeof(WithdrawalReason1Choice.Proprietary),
        nameof(WithdrawalReason1Choice.Proprietary)
    )]
    [IsoId("_NMNN8E7XEeifNrXGwadPmg")]
    [DisplayName("Withdrawal Reason 1 Choice")]
    public abstract record WithdrawalReason1Choice_ { }
}
