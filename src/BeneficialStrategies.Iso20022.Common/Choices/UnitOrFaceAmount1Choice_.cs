// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a unit in decimal number or a face amount in currency and amount.
    /// </summary>
    [KnownType(typeof(UnitOrFaceAmount1Choice.Unit))]
    [KnownType(typeof(UnitOrFaceAmount1Choice.FaceAmount))]
    [JsonDerivedType(typeof(UnitOrFaceAmount1Choice.Unit), nameof(UnitOrFaceAmount1Choice.Unit))]
    [JsonDerivedType(
        typeof(UnitOrFaceAmount1Choice.FaceAmount),
        nameof(UnitOrFaceAmount1Choice.FaceAmount)
    )]
    [IsoId("_SoRAwdp-Ed-ak6NoX_4Aeg_-514701328")]
    [DisplayName("Unit Or Face Amount 1 Choice")]
    public abstract record UnitOrFaceAmount1Choice_ { }
}
