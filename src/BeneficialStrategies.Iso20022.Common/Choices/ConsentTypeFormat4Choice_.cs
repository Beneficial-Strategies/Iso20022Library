// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the consent type format required.
    /// </summary>
    [KnownType(typeof(ConsentTypeFormat4Choice.Code))]
    [KnownType(typeof(ConsentTypeFormat4Choice.Proprietary))]
    [JsonDerivedType(typeof(ConsentTypeFormat4Choice.Code),nameof(ConsentTypeFormat4Choice.Code))]
    [JsonDerivedType(typeof(ConsentTypeFormat4Choice.Proprietary),nameof(ConsentTypeFormat4Choice.Proprietary))]
    [IsoId("_dyRgMUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Consent Type Format 4 Choice")]
    public abstract partial record ConsentTypeFormat4Choice_
    {
    }
}
