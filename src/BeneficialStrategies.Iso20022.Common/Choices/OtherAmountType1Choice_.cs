// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between formats for a type of amount.
    /// </summary>
    [KnownType(typeof(OtherAmountType1Choice.Code))]
    [KnownType(typeof(OtherAmountType1Choice.ProprietaryCode))]
    [JsonDerivedType(typeof(OtherAmountType1Choice.Code), nameof(OtherAmountType1Choice.Code))]
    [JsonDerivedType(
        typeof(OtherAmountType1Choice.ProprietaryCode),
        nameof(OtherAmountType1Choice.ProprietaryCode)
    )]
    [IsoId("_WLNL4I2NEeeNN9vGwZc5aA")]
    [DisplayName("Other Amount Type 1 Choice")]
    public abstract record OtherAmountType1Choice_ { }
}
