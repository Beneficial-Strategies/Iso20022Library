// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the return of the transaction.
    /// </summary>
    [KnownType(typeof(ReturnReason4Choice.Code))]
    [KnownType(typeof(ReturnReason4Choice.Proprietary))]
    [JsonDerivedType(typeof(ReturnReason4Choice.Code),nameof(ReturnReason4Choice.Code))]
    [JsonDerivedType(typeof(ReturnReason4Choice.Proprietary),nameof(ReturnReason4Choice.Proprietary))]
    [IsoId("_V5oD0dp-Ed-ak6NoX_4Aeg_434826033")]
    [DisplayName("Return Reason 4 Choice")]
    public abstract partial record ReturnReason4Choice_
    {
    }
}
