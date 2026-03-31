// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType3Choice.Code))]
    [KnownType(typeof(RepurchaseType3Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType3Choice.Code), nameof(RepurchaseType3Choice.Code))]
    [JsonDerivedType(
        typeof(RepurchaseType3Choice.Proprietary),
        nameof(RepurchaseType3Choice.Proprietary)
    )]
    [IsoId("_Qv3Usdp-Ed-ak6NoX_4Aeg_1174235540")]
    [DisplayName("Repurchase Type 3 Choice")]
    public abstract record RepurchaseType3Choice_ { }
}
