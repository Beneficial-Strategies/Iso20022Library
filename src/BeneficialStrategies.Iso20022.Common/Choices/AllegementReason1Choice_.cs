// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the allegment reason.
    /// </summary>
    [KnownType(typeof(AllegementReason1Choice.Code))]
    [KnownType(typeof(AllegementReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(AllegementReason1Choice.Code), nameof(AllegementReason1Choice.Code))]
    [JsonDerivedType(
        typeof(AllegementReason1Choice.Proprietary),
        nameof(AllegementReason1Choice.Proprietary)
    )]
    [IsoId("_mLyJ8WXREeOWzsrIp2keDA")]
    [DisplayName("Allegement Reason 1 Choice")]
    public abstract record AllegementReason1Choice_ { }
}
