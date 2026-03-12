// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the corporate action event type.
    /// </summary>
    [KnownType(typeof(CorporateAction1Choice.Type))]
    [KnownType(typeof(CorporateAction1Choice.Proprietary))]
    [JsonDerivedType(typeof(CorporateAction1Choice.Type),nameof(CorporateAction1Choice.Type))]
    [JsonDerivedType(typeof(CorporateAction1Choice.Proprietary),nameof(CorporateAction1Choice.Proprietary))]
    [IsoId("_nQWQgQf_EeSaceXTzyiZRg")]
    [DisplayName("Corporate Action 1 Choice")]
    public abstract partial record CorporateAction1Choice_
    {
    }
}
