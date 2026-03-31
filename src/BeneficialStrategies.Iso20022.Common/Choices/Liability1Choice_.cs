// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for liability.
    /// </summary>
    [KnownType(typeof(Liability1Choice.Code))]
    [KnownType(typeof(Liability1Choice.Proprietary))]
    [JsonDerivedType(typeof(Liability1Choice.Code), nameof(Liability1Choice.Code))]
    [JsonDerivedType(typeof(Liability1Choice.Proprietary), nameof(Liability1Choice.Proprietary))]
    [IsoId("_YmJhYCDMEeWPMvNwVtiMsA")]
    [DisplayName("Liability 1 Choice")]
    public abstract record Liability1Choice_ { }
}
