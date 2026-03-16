// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Standing Order Or Error10Choice.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError10Choice.BusinessError))]
    [KnownType(typeof(StandingOrderOrError10Choice.StandingOrder))]
    [JsonDerivedType(typeof(StandingOrderOrError10Choice.BusinessError),nameof(StandingOrderOrError10Choice.BusinessError))]
    [JsonDerivedType(typeof(StandingOrderOrError10Choice.StandingOrder),nameof(StandingOrderOrError10Choice.StandingOrder))]
    [IsoId("_z34ioTEyEe6g-ffJsqGiSA")]
    [DisplayName("Standing Order Or Error10Choice")]
    public abstract partial record StandingOrderOrError10Choice_
    {
    }
}
