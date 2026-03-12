// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the registration information.
    /// </summary>
    [KnownType(typeof(Registration7Choice.Code))]
    [KnownType(typeof(Registration7Choice.Proprietary))]
    [JsonDerivedType(typeof(Registration7Choice.Code),nameof(Registration7Choice.Code))]
    [JsonDerivedType(typeof(Registration7Choice.Proprietary),nameof(Registration7Choice.Proprietary))]
    [IsoId("_4HWEMRXZEeGmOJpfhCvx_g")]
    [DisplayName("Registration 7 Choice")]
    public abstract partial record Registration7Choice_
    {
    }
}
