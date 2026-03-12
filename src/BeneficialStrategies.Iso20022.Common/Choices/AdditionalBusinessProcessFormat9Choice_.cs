// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat9Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat9Choice.Proprietary))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat9Choice.Code),nameof(AdditionalBusinessProcessFormat9Choice.Code))]
    [JsonDerivedType(typeof(AdditionalBusinessProcessFormat9Choice.Proprietary),nameof(AdditionalBusinessProcessFormat9Choice.Proprietary))]
    [IsoId("_EXH7gUEGEeWVgfuHGaKtRQ")]
    [DisplayName("Additional Business Process Format 9 Choice")]
    public abstract partial record AdditionalBusinessProcessFormat9Choice_
    {
    }
}
