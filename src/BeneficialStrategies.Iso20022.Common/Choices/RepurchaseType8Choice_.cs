// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType8Choice.Code))]
    [KnownType(typeof(RepurchaseType8Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType8Choice.Code),nameof(RepurchaseType8Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType8Choice.Proprietary),nameof(RepurchaseType8Choice.Proprietary))]
    [IsoId("_GS4Cgd0dEd-Cb-IGbQ4hBQ")]
    [DisplayName("Repurchase Type 8 Choice")]
    public abstract partial record RepurchaseType8Choice_
    {
    }
}
