// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Speficies the reason for the transaction cancellation status.
    /// </summary>
    [KnownType(typeof(CancellationStatusReason1Choice.Code))]
    [KnownType(typeof(CancellationStatusReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationStatusReason1Choice.Code),
        nameof(CancellationStatusReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationStatusReason1Choice.Proprietary),
        nameof(CancellationStatusReason1Choice.Proprietary)
    )]
    [IsoId("_TPwel9p-Ed-ak6NoX_4Aeg_1784056923")]
    [DisplayName("Cancellation Status Reason 1 Choice")]
    public abstract record CancellationStatusReason1Choice_ { }
}
