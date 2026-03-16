// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of the credit line provided.
    /// </summary>
    [KnownType(typeof(CreditLineType1Choice.Code))]
    [KnownType(typeof(CreditLineType1Choice.Proprietary))]
    [JsonDerivedType(typeof(CreditLineType1Choice.Code), nameof(CreditLineType1Choice.Code))]
    [JsonDerivedType(
        typeof(CreditLineType1Choice.Proprietary),
        nameof(CreditLineType1Choice.Proprietary)
    )]
    [IsoId("_2T3LxIZ5Eee8r9VKRbnJSg")]
    [DisplayName("Credit Line Type 1 Choice")]
    public abstract record CreditLineType1Choice_ { }
}
