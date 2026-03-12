// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the Foreign Account Tax Compliance Act (FATCA) status.
    /// </summary>
    [KnownType(typeof(FATCAStatus2Choice.Code))]
    [KnownType(typeof(FATCAStatus2Choice.Proprietary))]
    [JsonDerivedType(typeof(FATCAStatus2Choice.Code),nameof(FATCAStatus2Choice.Code))]
    [JsonDerivedType(typeof(FATCAStatus2Choice.Proprietary),nameof(FATCAStatus2Choice.Proprietary))]
    [IsoId("_v4N-sSCVEeWJd9HF2tO7BA")]
    [DisplayName("FATCA Status 2 Choice")]
    public abstract partial record FATCAStatus2Choice_
    {
    }
}
