// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides detailed information on the service request status.
    /// </summary>
    [KnownType(typeof(ServiceStatus1Choice.Code))]
    [KnownType(typeof(ServiceStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(ServiceStatus1Choice.Code), nameof(ServiceStatus1Choice.Code))]
    [JsonDerivedType(
        typeof(ServiceStatus1Choice.Proprietary),
        nameof(ServiceStatus1Choice.Proprietary)
    )]
    [IsoId("_z_f3DfDXEemsS_0xy2XRug")]
    [DisplayName("Service Status 1 Choice")]
    public abstract record ServiceStatus1Choice_ { }
}
