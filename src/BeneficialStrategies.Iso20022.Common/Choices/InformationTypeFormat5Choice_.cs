// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the information type format required.
    /// </summary>
    [KnownType(typeof(InformationTypeFormat5Choice.Code))]
    [KnownType(typeof(InformationTypeFormat5Choice.Proprietary))]
    [JsonDerivedType(typeof(InformationTypeFormat5Choice.Code),nameof(InformationTypeFormat5Choice.Code))]
    [JsonDerivedType(typeof(InformationTypeFormat5Choice.Proprietary),nameof(InformationTypeFormat5Choice.Proprietary))]
    [IsoId("_c5Whl5KQEeWHWpTQn1FFVg")]
    [DisplayName("Information Type Format 5 Choice")]
    public abstract partial record InformationTypeFormat5Choice_
    {
    }
}
