// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the specification of the data in a structured or unstructured form.
    /// </summary>
    [KnownType(typeof(DataFormat2Choice.Structured))]
    [KnownType(typeof(DataFormat2Choice.Unstructured))]
    [JsonDerivedType(typeof(DataFormat2Choice.Structured),nameof(DataFormat2Choice.Structured))]
    [JsonDerivedType(typeof(DataFormat2Choice.Unstructured),nameof(DataFormat2Choice.Unstructured))]
    [IsoId("_Q6vvBdp-Ed-ak6NoX_4Aeg_-2133276556")]
    [DisplayName("Data Format 2 Choice")]
    public abstract partial record DataFormat2Choice_
    {
    }
}
