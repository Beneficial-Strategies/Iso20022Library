// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the source of the Common Reporting Standard (CRS).
    /// </summary>
    [KnownType(typeof(CRSSource1Choice.Code))]
    [KnownType(typeof(CRSSource1Choice.Proprietary))]
    [JsonDerivedType(typeof(CRSSource1Choice.Code),nameof(CRSSource1Choice.Code))]
    [JsonDerivedType(typeof(CRSSource1Choice.Proprietary),nameof(CRSSource1Choice.Proprietary))]
    [IsoId("_JdcmcUNfEeamLdeYEZm56w")]
    [DisplayName("CRS Source 1 Choice")]
    public abstract partial record CRSSource1Choice_
    {
    }
}
