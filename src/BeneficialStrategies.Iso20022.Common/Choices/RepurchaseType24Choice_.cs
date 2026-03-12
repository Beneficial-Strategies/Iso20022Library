// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType24Choice.Code))]
    [KnownType(typeof(RepurchaseType24Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType24Choice.Code),nameof(RepurchaseType24Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType24Choice.Proprietary),nameof(RepurchaseType24Choice.Proprietary))]
    [IsoId("_pAgRT5wxEeazcsnODTksnQ")]
    [DisplayName("Repurchase Type 24 Choice")]
    public abstract partial record RepurchaseType24Choice_
    {
    }
}
