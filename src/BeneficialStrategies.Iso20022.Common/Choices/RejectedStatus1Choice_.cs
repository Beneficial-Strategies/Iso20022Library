// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a reason or no reason for the corporate action instruction processing rejected status.
    /// </summary>
    [KnownType(typeof(RejectedStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectedStatus1Choice.Reason))]
    [JsonDerivedType(
        typeof(RejectedStatus1Choice.NoSpecifiedReason),
        nameof(RejectedStatus1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(RejectedStatus1Choice.Reason), nameof(RejectedStatus1Choice.Reason))]
    [IsoId("_QyjcVNp-Ed-ak6NoX_4Aeg_-600470568")]
    [DisplayName("Rejected Status 1 Choice")]
    public abstract record RejectedStatus1Choice_ { }
}
