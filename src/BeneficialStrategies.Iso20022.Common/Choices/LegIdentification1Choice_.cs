// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of leg.
    /// </summary>
    [KnownType(typeof(LegIdentification1Choice.RedemptionLegIdentification))]
    [KnownType(typeof(LegIdentification1Choice.SubscriptionLegIdentification))]
    [JsonDerivedType(typeof(LegIdentification1Choice.RedemptionLegIdentification),nameof(LegIdentification1Choice.RedemptionLegIdentification))]
    [JsonDerivedType(typeof(LegIdentification1Choice.SubscriptionLegIdentification),nameof(LegIdentification1Choice.SubscriptionLegIdentification))]
    [IsoId("_r7QIIEglEea9YuSvQGoi-w")]
    [DisplayName("Leg Identification 1 Choice")]
    public abstract partial record LegIdentification1Choice_
    {
    }
}
