// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code and a data source scheme to specify the type of alternate identification.
    /// </summary>
    [KnownType(typeof(IdentificationType42Choice.Code))]
    [KnownType(typeof(IdentificationType42Choice.Proprietary))]
    [JsonDerivedType(typeof(IdentificationType42Choice.Code),nameof(IdentificationType42Choice.Code))]
    [JsonDerivedType(typeof(IdentificationType42Choice.Proprietary),nameof(IdentificationType42Choice.Proprietary))]
    [IsoId("_m6TxQR5gEeWE3PufGMdJ3w")]
    [DisplayName("Identification Type 42 Choice")]
    public abstract partial record IdentificationType42Choice_
    {
    }
}
