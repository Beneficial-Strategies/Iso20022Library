// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies a channel type.
    /// </summary>
    [KnownType(typeof(Channel2Choice.Code))]
    [KnownType(typeof(Channel2Choice.Proprietary))]
    [JsonDerivedType(typeof(Channel2Choice.Code), nameof(Channel2Choice.Code))]
    [JsonDerivedType(typeof(Channel2Choice.Proprietary), nameof(Channel2Choice.Proprietary))]
    [IsoId("_1zp30Bg2EeKnW4lR85q-0A")]
    [DisplayName("Channel 2 Choice")]
    public abstract record Channel2Choice_ { }
}
