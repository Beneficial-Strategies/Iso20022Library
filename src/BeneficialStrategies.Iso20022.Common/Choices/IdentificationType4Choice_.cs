// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a data source scheme to specify the type of alternate identification.
    /// </summary>
    [KnownType(typeof(IdentificationType4Choice.Code))]
    [KnownType(typeof(IdentificationType4Choice.Proprietary))]
    [JsonDerivedType(typeof(IdentificationType4Choice.Code),nameof(IdentificationType4Choice.Code))]
    [JsonDerivedType(typeof(IdentificationType4Choice.Proprietary),nameof(IdentificationType4Choice.Proprietary))]
    [IsoId("_Q4qEW9p-Ed-ak6NoX_4Aeg_436704411")]
    [DisplayName("Identification Type 4 Choice")]
    public abstract partial record IdentificationType4Choice_
    {
    }
}
