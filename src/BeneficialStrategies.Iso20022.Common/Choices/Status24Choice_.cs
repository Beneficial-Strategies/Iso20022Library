// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of status.
    /// </summary>
    [KnownType(typeof(Status24Choice.OrderDetailsReport))]
    [KnownType(typeof(Status24Choice.IndividualOrderDetailsReport))]
    [KnownType(typeof(Status24Choice.SwitchOrderDetailsReport))]
    [JsonDerivedType(
        typeof(Status24Choice.OrderDetailsReport),
        nameof(Status24Choice.OrderDetailsReport)
    )]
    [JsonDerivedType(
        typeof(Status24Choice.IndividualOrderDetailsReport),
        nameof(Status24Choice.IndividualOrderDetailsReport)
    )]
    [JsonDerivedType(
        typeof(Status24Choice.SwitchOrderDetailsReport),
        nameof(Status24Choice.SwitchOrderDetailsReport)
    )]
    [IsoId("_N37HcEHPEeazV4RAqPV71g")]
    [DisplayName("Status 24 Choice")]
    public abstract record Status24Choice_ { }
}
