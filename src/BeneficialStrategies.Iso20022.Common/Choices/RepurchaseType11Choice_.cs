// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType11Choice.Code))]
    [KnownType(typeof(RepurchaseType11Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType11Choice.Code),nameof(RepurchaseType11Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType11Choice.Proprietary),nameof(RepurchaseType11Choice.Proprietary))]
    [IsoId("_AZjk8dokEeC60axPepSq7g_-144668299")]
    [DisplayName("Repurchase Type 11 Choice")]
    public abstract partial record RepurchaseType11Choice_
    {
    }
}
