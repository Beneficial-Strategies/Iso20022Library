// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the registration information.
    /// </summary>
    [KnownType(typeof(Registration3Choice.Code))]
    [KnownType(typeof(Registration3Choice.Proprietary))]
    [JsonDerivedType(typeof(Registration3Choice.Code),nameof(Registration3Choice.Code))]
    [JsonDerivedType(typeof(Registration3Choice.Proprietary),nameof(Registration3Choice.Proprietary))]
    [IsoId("_b85JsfIrEd-dOvqmSLSz5g")]
    [DisplayName("Registration 3 Choice")]
    public abstract partial record Registration3Choice_
    {
    }
}
