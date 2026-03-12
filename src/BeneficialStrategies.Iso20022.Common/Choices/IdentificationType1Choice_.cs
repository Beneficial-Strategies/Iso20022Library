// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Information related to an identification, eg, party identification or account identification.
    /// </summary>
    [KnownType(typeof(IdentificationType1Choice.IdentificationType))]
    [KnownType(typeof(IdentificationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(IdentificationType1Choice.IdentificationType),nameof(IdentificationType1Choice.IdentificationType))]
    [JsonDerivedType(typeof(IdentificationType1Choice.Proprietary),nameof(IdentificationType1Choice.Proprietary))]
    [IsoId("_QAoQJtp-Ed-ak6NoX_4Aeg_-1560497991")]
    [DisplayName("Identification Type 1 Choice")]
    public abstract partial record IdentificationType1Choice_
    {
    }
}
