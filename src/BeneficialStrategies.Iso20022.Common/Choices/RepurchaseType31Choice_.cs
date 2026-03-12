// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType31Choice.Code))]
    [KnownType(typeof(RepurchaseType31Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType31Choice.Code),nameof(RepurchaseType31Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType31Choice.Proprietary),nameof(RepurchaseType31Choice.Proprietary))]
    [IsoId("_yYMhnZw2EeazcsnODTksnQ")]
    [DisplayName("Repurchase Type 31 Choice")]
    public abstract partial record RepurchaseType31Choice_
    {
    }
}
