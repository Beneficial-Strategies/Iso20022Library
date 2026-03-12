// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the denied reason.
    /// </summary>
    [KnownType(typeof(DeniedReason24Choice.Code))]
    [KnownType(typeof(DeniedReason24Choice.Proprietary))]
    [JsonDerivedType(typeof(DeniedReason24Choice.Code),nameof(DeniedReason24Choice.Code))]
    [JsonDerivedType(typeof(DeniedReason24Choice.Proprietary),nameof(DeniedReason24Choice.Proprietary))]
    [IsoId("_vnmOEZkNEeWn2ur3BXxtdg")]
    [DisplayName("Denied Reason 24 Choice")]
    public abstract partial record DeniedReason24Choice_
    {
    }
}
