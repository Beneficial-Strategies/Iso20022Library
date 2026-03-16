// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Investigation Request Action1Choice.
    /// </summary>
    [KnownType(typeof(InvestigationRequestAction1Choice.Code))]
    [KnownType(typeof(InvestigationRequestAction1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(InvestigationRequestAction1Choice.Code),
        nameof(InvestigationRequestAction1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(InvestigationRequestAction1Choice.Proprietary),
        nameof(InvestigationRequestAction1Choice.Proprietary)
    )]
    [IsoId("_RsHK8RZZEe6d6Ip1Ob2kaQ")]
    [DisplayName("Investigation Request Action1Choice")]
    public abstract record InvestigationRequestAction1Choice_ { }
}
