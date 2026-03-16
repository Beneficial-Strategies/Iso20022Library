// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Standing Order Or Error9Choice.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError9Choice.OperationalError))]
    [KnownType(typeof(StandingOrderOrError9Choice.Report))]
    [JsonDerivedType(typeof(StandingOrderOrError9Choice.OperationalError),nameof(StandingOrderOrError9Choice.OperationalError))]
    [JsonDerivedType(typeof(StandingOrderOrError9Choice.Report),nameof(StandingOrderOrError9Choice.Report))]
    [IsoId("_zzZEMTEyEe6g-ffJsqGiSA")]
    [DisplayName("Standing Order Or Error9Choice")]
    public abstract partial record StandingOrderOrError9Choice_
    {
    }
}
