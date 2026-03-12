// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the status of the transaction.
    /// </summary>
    [KnownType(typeof(StatusReason5Choice.Code))]
    [KnownType(typeof(StatusReason5Choice.Proprietary))]
    [JsonDerivedType(typeof(StatusReason5Choice.Code),nameof(StatusReason5Choice.Code))]
    [JsonDerivedType(typeof(StatusReason5Choice.Proprietary),nameof(StatusReason5Choice.Proprietary))]
    [IsoId("_V5oD19p-Ed-ak6NoX_4Aeg_1860744769")]
    [DisplayName("Status Reason 5 Choice")]
    public abstract partial record StatusReason5Choice_
    {
    }
}
