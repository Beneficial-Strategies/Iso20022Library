// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the additional business process, that is, a tax refund.
    /// </summary>
    [KnownType(typeof(AdditionalBusinessProcessFormat11Choice.Code))]
    [KnownType(typeof(AdditionalBusinessProcessFormat11Choice.Proprietary))]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat11Choice.Code),
        nameof(AdditionalBusinessProcessFormat11Choice.Code)
    )]
    [JsonDerivedType(
        typeof(AdditionalBusinessProcessFormat11Choice.Proprietary),
        nameof(AdditionalBusinessProcessFormat11Choice.Proprietary)
    )]
    [IsoId("_ZSMB8UGPEeWqy4niLuXETA")]
    [DisplayName("Additional Business Process Format 11 Choice")]
    public abstract record AdditionalBusinessProcessFormat11Choice_ { }
}
