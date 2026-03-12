// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine a date format.
    /// </summary>
    [KnownType(typeof(Date3Choice.Code))]
    [KnownType(typeof(Date3Choice.Proprietary))]
    [JsonDerivedType(typeof(Date3Choice.Code),nameof(Date3Choice.Code))]
    [JsonDerivedType(typeof(Date3Choice.Proprietary),nameof(Date3Choice.Proprietary))]
    [IsoId("_UmGspZEhEeakHoV5BVecAQ")]
    [DisplayName("Date 3 Choice")]
    public abstract partial record Date3Choice_
    {
    }
}
