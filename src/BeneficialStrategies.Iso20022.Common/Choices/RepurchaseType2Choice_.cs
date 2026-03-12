// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType2Choice.Code))]
    [KnownType(typeof(RepurchaseType2Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType2Choice.Code),nameof(RepurchaseType2Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType2Choice.Proprietary),nameof(RepurchaseType2Choice.Proprietary))]
    [IsoId("_QtL0Jdp-Ed-ak6NoX_4Aeg_285985129")]
    [DisplayName("Repurchase Type 2 Choice")]
    public abstract partial record RepurchaseType2Choice_
    {
    }
}
