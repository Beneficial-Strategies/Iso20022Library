// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the information type format required.
    /// </summary>
    [KnownType(typeof(InformationTypeFormat4Choice.Code))]
    [KnownType(typeof(InformationTypeFormat4Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InformationTypeFormat4Choice.Code),
        nameof(InformationTypeFormat4Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InformationTypeFormat4Choice.Proprietary),
        nameof(InformationTypeFormat4Choice.Proprietary)
    )]
    [IsoId("_gfTHIUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Information Type Format 4 Choice")]
    public abstract record InformationTypeFormat4Choice_ { }
}
