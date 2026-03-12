// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the status of the transaction.
    /// </summary>
    [KnownType(typeof(StatusReason1Choice.Code))]
    [KnownType(typeof(StatusReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(StatusReason1Choice.Code),nameof(StatusReason1Choice.Code))]
    [JsonDerivedType(typeof(StatusReason1Choice.Proprietary),nameof(StatusReason1Choice.Proprietary))]
    [IsoId("_TPA3udp-Ed-ak6NoX_4Aeg_-1029924222")]
    [DisplayName("Status Reason 1 Choice")]
    public abstract partial record StatusReason1Choice_
    {
    }
}
