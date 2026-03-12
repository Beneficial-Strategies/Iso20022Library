// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the allegement status.
    /// </summary>
    [KnownType(typeof(AllegementStatus3Choice.Code))]
    [KnownType(typeof(AllegementStatus3Choice.Proprietary))]
    [JsonDerivedType(typeof(AllegementStatus3Choice.Code),nameof(AllegementStatus3Choice.Code))]
    [JsonDerivedType(typeof(AllegementStatus3Choice.Proprietary),nameof(AllegementStatus3Choice.Proprietary))]
    [IsoId("_TlRHgTqhEeWyoP0PbocV1Q")]
    [DisplayName("Allegement Status 3 Choice")]
    public abstract partial record AllegementStatus3Choice_
    {
    }
}
