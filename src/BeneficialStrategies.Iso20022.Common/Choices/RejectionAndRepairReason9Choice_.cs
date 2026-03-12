// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the rejection or repair reason.
    /// </summary>
    [KnownType(typeof(RejectionAndRepairReason9Choice.Code))]
    [KnownType(typeof(RejectionAndRepairReason9Choice.Proprietary))]
    [JsonDerivedType(typeof(RejectionAndRepairReason9Choice.Code),nameof(RejectionAndRepairReason9Choice.Code))]
    [JsonDerivedType(typeof(RejectionAndRepairReason9Choice.Proprietary),nameof(RejectionAndRepairReason9Choice.Proprietary))]
    [IsoId("_ekEaIeZgEd-q8fx_Zl_34A")]
    [DisplayName("Rejection And Repair Reason 9 Choice")]
    public abstract partial record RejectionAndRepairReason9Choice_
    {
    }
}
