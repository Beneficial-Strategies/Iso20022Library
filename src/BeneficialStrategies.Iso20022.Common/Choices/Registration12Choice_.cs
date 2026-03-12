// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the registration information.
    /// </summary>
    [KnownType(typeof(Registration12Choice.Code))]
    [KnownType(typeof(Registration12Choice.Proprietary))]
    [JsonDerivedType(typeof(Registration12Choice.Code),nameof(Registration12Choice.Code))]
    [JsonDerivedType(typeof(Registration12Choice.Proprietary),nameof(Registration12Choice.Proprietary))]
    [IsoId("_6GWV9ZNLEeWGlc8L7oPDIg")]
    [DisplayName("Registration 12 Choice")]
    public abstract partial record Registration12Choice_
    {
    }
}
