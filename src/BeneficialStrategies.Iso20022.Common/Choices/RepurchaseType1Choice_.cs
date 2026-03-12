// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the repurchase transaction type information.
    /// </summary>
    [KnownType(typeof(RepurchaseType1Choice.Code))]
    [KnownType(typeof(RepurchaseType1Choice.Proprietary))]
    [JsonDerivedType(typeof(RepurchaseType1Choice.Code),nameof(RepurchaseType1Choice.Code))]
    [JsonDerivedType(typeof(RepurchaseType1Choice.Proprietary),nameof(RepurchaseType1Choice.Proprietary))]
    [IsoId("_QuFMAtp-Ed-ak6NoX_4Aeg_-618677021")]
    [DisplayName("Repurchase Type 1 Choice")]
    public abstract partial record RepurchaseType1Choice_
    {
    }
}
