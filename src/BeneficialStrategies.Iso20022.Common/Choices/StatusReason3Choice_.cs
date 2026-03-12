// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the status of the transaction.
    /// </summary>
    [KnownType(typeof(StatusReason3Choice.Code))]
    [KnownType(typeof(StatusReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(StatusReason3Choice.Code),nameof(StatusReason3Choice.Code))]
    [JsonDerivedType(typeof(StatusReason3Choice.Proprietary),nameof(StatusReason3Choice.Proprietary))]
    [IsoId("_V8w3Y9p-Ed-ak6NoX_4Aeg_-860400525")]
    [DisplayName("Status Reason 3 Choice")]
    public abstract partial record StatusReason3Choice_
    {
    }
}
