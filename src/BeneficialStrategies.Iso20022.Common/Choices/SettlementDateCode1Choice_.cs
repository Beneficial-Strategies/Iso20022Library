// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the settlement date code.
    /// </summary>
    [KnownType(typeof(SettlementDateCode1Choice.Code))]
    [KnownType(typeof(SettlementDateCode1Choice.Proprietary))]
    [JsonDerivedType(typeof(SettlementDateCode1Choice.Code),nameof(SettlementDateCode1Choice.Code))]
    [JsonDerivedType(typeof(SettlementDateCode1Choice.Proprietary),nameof(SettlementDateCode1Choice.Proprietary))]
    [IsoId("_QvRe0Np-Ed-ak6NoX_4Aeg_308749085")]
    [DisplayName("Settlement Date Code 1 Choice")]
    public abstract partial record SettlementDateCode1Choice_
    {
    }
}
