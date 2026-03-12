// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the closing of the securities lending contract.
    /// </summary>
    [KnownType(typeof(Reversible2Choice.Code))]
    [KnownType(typeof(Reversible2Choice.Proprietary))]
    [JsonDerivedType(typeof(Reversible2Choice.Code),nameof(Reversible2Choice.Code))]
    [JsonDerivedType(typeof(Reversible2Choice.Proprietary),nameof(Reversible2Choice.Proprietary))]
    [IsoId("_PFD-kZEkEeakHoV5BVecAQ")]
    [DisplayName("Reversible 2 Choice")]
    public abstract partial record Reversible2Choice_
    {
    }
}
