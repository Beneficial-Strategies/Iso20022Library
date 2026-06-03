// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats to express the accepted with warning status of the notification advice.
    /// </summary>
    [KnownType(typeof(AcceptedWithWarningStatus1Format1Choice.Code))]
    [KnownType(typeof(AcceptedWithWarningStatus1Format1Choice.Proprietary))]
    [JsonDerivedType(typeof(AcceptedWithWarningStatus1Format1Choice.Code), nameof(AcceptedWithWarningStatus1Format1Choice.Code))]
    [JsonDerivedType(typeof(AcceptedWithWarningStatus1Format1Choice.Proprietary), nameof(AcceptedWithWarningStatus1Format1Choice.Proprietary))]
    [IsoId("__uhZAaUdEfCnE_wCEfCqTA")]
    [DisplayName("AcceptedWithWarningStatus1Format1Choice")]
    public abstract record AcceptedWithWarningStatus1Format1Choice_ { }
}
