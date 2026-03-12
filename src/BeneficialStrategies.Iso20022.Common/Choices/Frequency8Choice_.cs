// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the frequency.
    /// </summary>
    [KnownType(typeof(Frequency8Choice.Code))]
    [KnownType(typeof(Frequency8Choice.Proprietary))]
    [JsonDerivedType(typeof(Frequency8Choice.Code),nameof(Frequency8Choice.Code))]
    [JsonDerivedType(typeof(Frequency8Choice.Proprietary),nameof(Frequency8Choice.Proprietary))]
    [IsoId("_m_xsdfNBEeCuA5Tr22BnwA_2080535464")]
    [DisplayName("Frequency 8 Choice")]
    public abstract partial record Frequency8Choice_
    {
    }
}
