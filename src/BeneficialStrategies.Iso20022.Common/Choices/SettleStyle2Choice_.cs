// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for settle style.
    /// </summary>
    [KnownType(typeof(SettleStyle2Choice.Code))]
    [KnownType(typeof(SettleStyle2Choice.Proprietary))]
    [JsonDerivedType(typeof(SettleStyle2Choice.Code),nameof(SettleStyle2Choice.Code))]
    [JsonDerivedType(typeof(SettleStyle2Choice.Proprietary),nameof(SettleStyle2Choice.Proprietary))]
    [IsoId("_rPPgweLaEeWFtOV72FbX9w")]
    [DisplayName("Settle Style 2 Choice")]
    public abstract partial record SettleStyle2Choice_
    {
    }
}
