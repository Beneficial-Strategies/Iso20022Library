// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the standing order details or an operational error when the requested data cannot be retrieved.
    /// </summary>
    [KnownType(typeof(StandingOrderOrError7Choice.Report))]
    [KnownType(typeof(StandingOrderOrError7Choice.OperationalError))]
    [JsonDerivedType(typeof(StandingOrderOrError7Choice.Report),nameof(StandingOrderOrError7Choice.Report))]
    [JsonDerivedType(typeof(StandingOrderOrError7Choice.OperationalError),nameof(StandingOrderOrError7Choice.OperationalError))]
    [IsoId("_eZL10dcZEeqRFcf2R4bPBw")]
    [DisplayName("Standing Order Or Error 7 Choice")]
    public abstract partial record StandingOrderOrError7Choice_
    {
    }
}
