// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the return of the transaction.
    /// </summary>
    [KnownType(typeof(ReturnReason3Choice.Code))]
    [KnownType(typeof(ReturnReason3Choice.Proprietary))]
    [JsonDerivedType(typeof(ReturnReason3Choice.Code),nameof(ReturnReason3Choice.Code))]
    [JsonDerivedType(typeof(ReturnReason3Choice.Proprietary),nameof(ReturnReason3Choice.Proprietary))]
    [IsoId("_V86BUNp-Ed-ak6NoX_4Aeg_1314268280")]
    [DisplayName("Return Reason 3 Choice")]
    public abstract partial record ReturnReason3Choice_
    {
    }
}
