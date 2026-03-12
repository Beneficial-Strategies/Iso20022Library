// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Limit details of one or more limits set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(LimitStructure1Choice.CurrentLimitIdentification))]
    [KnownType(typeof(LimitStructure1Choice.AllCurrentLimits))]
    [JsonDerivedType(typeof(LimitStructure1Choice.CurrentLimitIdentification),nameof(LimitStructure1Choice.CurrentLimitIdentification))]
    [JsonDerivedType(typeof(LimitStructure1Choice.AllCurrentLimits),nameof(LimitStructure1Choice.AllCurrentLimits))]
    [IsoId("_72iECKMgEeCJ6YNENx4h-w_-879339844")]
    [DisplayName("Limit Structure 1 Choice")]
    public abstract partial record LimitStructure1Choice_
    {
    }
}
