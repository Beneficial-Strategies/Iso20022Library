// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of election movement.
    /// </summary>
    [KnownType(typeof(ElectionTypeFormat3Choice.Code))]
    [KnownType(typeof(ElectionTypeFormat3Choice.Proprietary))]
    [JsonDerivedType(typeof(ElectionTypeFormat3Choice.Code),nameof(ElectionTypeFormat3Choice.Code))]
    [JsonDerivedType(typeof(ElectionTypeFormat3Choice.Proprietary),nameof(ElectionTypeFormat3Choice.Proprietary))]
    [IsoId("_TnPPkUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Election Type Format 3 Choice")]
    public abstract partial record ElectionTypeFormat3Choice_
    {
    }
}
