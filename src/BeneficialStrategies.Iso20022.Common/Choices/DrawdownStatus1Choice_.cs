// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a drawdown status.
    /// </summary>
    [KnownType(typeof(DrawdownStatus1Choice.Code))]
    [KnownType(typeof(DrawdownStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(DrawdownStatus1Choice.Code),nameof(DrawdownStatus1Choice.Code))]
    [JsonDerivedType(typeof(DrawdownStatus1Choice.Proprietary),nameof(DrawdownStatus1Choice.Proprietary))]
    [IsoId("_bM0XwFKiEeiSDqv62fL07g")]
    [DisplayName("Drawdown Status 1 Choice")]
    public abstract partial record DrawdownStatus1Choice_
    {
    }
}
