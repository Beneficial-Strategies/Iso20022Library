// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of other identification.
    /// </summary>
    [KnownType(typeof(OtherIdentification3Choice.Code))]
    [KnownType(typeof(OtherIdentification3Choice.Proprietary))]
    [JsonDerivedType(typeof(OtherIdentification3Choice.Code),nameof(OtherIdentification3Choice.Code))]
    [JsonDerivedType(typeof(OtherIdentification3Choice.Proprietary),nameof(OtherIdentification3Choice.Proprietary))]
    [IsoId("_05uN4SCOEeWJd9HF2tO7BA")]
    [DisplayName("Other Identification 3 Choice")]
    public abstract partial record OtherIdentification3Choice_
    {
    }
}
