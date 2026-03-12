// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of action to be performed in the request.
    /// </summary>
    [KnownType(typeof(RequestType3Choice.Code))]
    [KnownType(typeof(RequestType3Choice.Proprietary))]
    [JsonDerivedType(typeof(RequestType3Choice.Code),nameof(RequestType3Choice.Code))]
    [JsonDerivedType(typeof(RequestType3Choice.Proprietary),nameof(RequestType3Choice.Proprietary))]
    [IsoId("_72rN86MgEeCJ6YNENx4h-w_-777871353")]
    [DisplayName("Request Type 3 Choice")]
    public abstract partial record RequestType3Choice_
    {
    }
}
