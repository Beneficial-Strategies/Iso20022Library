// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for a transfer reason.
    /// </summary>
    [KnownType(typeof(TransferReason1Choice.Code))]
    [KnownType(typeof(TransferReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(TransferReason1Choice.Code),nameof(TransferReason1Choice.Code))]
    [JsonDerivedType(typeof(TransferReason1Choice.Proprietary),nameof(TransferReason1Choice.Proprietary))]
    [IsoId("_hPw_oa51EeeMy7TnJ3e__g")]
    [DisplayName("Transfer Reason 1 Choice")]
    public abstract partial record TransferReason1Choice_
    {
    }
}
