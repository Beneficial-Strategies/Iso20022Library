// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the commission type.
    /// </summary>
    [KnownType(typeof(CommissionType6Choice.Code))]
    [KnownType(typeof(CommissionType6Choice.Proprietary))]
    [JsonDerivedType(typeof(CommissionType6Choice.Code),nameof(CommissionType6Choice.Code))]
    [JsonDerivedType(typeof(CommissionType6Choice.Proprietary),nameof(CommissionType6Choice.Proprietary))]
    [IsoId("_SU7-gZBhEeakHoV5BVecAQ")]
    [DisplayName("Commission Type 6 Choice")]
    public abstract partial record CommissionType6Choice_
    {
    }
}
