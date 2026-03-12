// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType16Choice.Code))]
    [KnownType(typeof(RepurchaseType16Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType16Choice.Code),nameof(RepurchaseType16Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType16Choice.Proprietary),nameof(RepurchaseType16Choice.Proprietary))]
    [IsoId("_5-A5U5NLEeWGlc8L7oPDIg")]
    [DisplayName("Repurchase Type 16 Choice")]
    public abstract partial record RepurchaseType16Choice_
    {
    }
}
