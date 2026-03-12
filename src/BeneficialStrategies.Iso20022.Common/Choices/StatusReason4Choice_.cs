// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the status of the transaction.
    /// </summary>
    [KnownType(typeof(StatusReason4Choice.Code))]
    [KnownType(typeof(StatusReason4Choice.Proprietary))]
    [JsonDerivedType(typeof(StatusReason4Choice.Code),nameof(StatusReason4Choice.Code))]
    [JsonDerivedType(typeof(StatusReason4Choice.Proprietary),nameof(StatusReason4Choice.Proprietary))]
    [IsoId("_TPdjpdp-Ed-ak6NoX_4Aeg_46429921")]
    [DisplayName("Status Reason 4 Choice")]
    public abstract partial record StatusReason4Choice_
    {
    }
}
