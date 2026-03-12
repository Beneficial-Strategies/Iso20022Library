// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionOrRepairStatus11Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionOrRepairStatus11Choice.Reason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus11Choice.NoSpecifiedReason),nameof(RejectionOrRepairStatus11Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionOrRepairStatus11Choice.Reason),nameof(RejectionOrRepairStatus11Choice.Reason))]
    [IsoId("_Ln8BkfI4Ed-dOvqmSLSz5g")]
    [DisplayName("Rejection Or Repair Status 11 Choice")]
    public abstract partial record RejectionOrRepairStatus11Choice_
    {
    }
}
