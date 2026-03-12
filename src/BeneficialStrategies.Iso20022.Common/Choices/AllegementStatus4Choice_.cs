// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the allegement status.
    /// </summary>
    [KnownType(typeof(AllegementStatus4Choice.Code))]
    [KnownType(typeof(AllegementStatus4Choice.Proprietary))]
    [JsonDerivedType(typeof(AllegementStatus4Choice.Code),nameof(AllegementStatus4Choice.Code))]
    [JsonDerivedType(typeof(AllegementStatus4Choice.Proprietary),nameof(AllegementStatus4Choice.Proprietary))]
    [IsoId("_6MjsLZNLEeWGlc8L7oPDIg")]
    [DisplayName("Allegement Status 4 Choice")]
    public abstract partial record AllegementStatus4Choice_
    {
    }
}
