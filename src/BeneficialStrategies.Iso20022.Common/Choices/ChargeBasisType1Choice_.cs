// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the charge basis.
    /// </summary>
    [KnownType(typeof(ChargeBasisType1Choice.Code))]
    [KnownType(typeof(ChargeBasisType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeBasisType1Choice.Code), nameof(ChargeBasisType1Choice.Code))]
    [JsonDerivedType(
        typeof(ChargeBasisType1Choice.Proprietary),
        nameof(ChargeBasisType1Choice.Proprietary)
    )]
    [IsoId("_2HEJAWZ5EeSQMqOS_ceSQA")]
    [DisplayName("Charge Basis Type 1 Choice")]
    public abstract record ChargeBasisType1Choice_ { }
}
