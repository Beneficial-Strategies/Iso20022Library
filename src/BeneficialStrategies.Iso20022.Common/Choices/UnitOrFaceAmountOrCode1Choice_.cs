// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a unit in decimal number, a face amount in currency and amount or a unit expressed as a code.
    /// </summary>
    [KnownType(typeof(UnitOrFaceAmountOrCode1Choice.Unit))]
    [KnownType(typeof(UnitOrFaceAmountOrCode1Choice.FaceAmount))]
    [KnownType(typeof(UnitOrFaceAmountOrCode1Choice.Code))]
    [JsonDerivedType(
        typeof(UnitOrFaceAmountOrCode1Choice.Unit),
        nameof(UnitOrFaceAmountOrCode1Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(UnitOrFaceAmountOrCode1Choice.FaceAmount),
        nameof(UnitOrFaceAmountOrCode1Choice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(UnitOrFaceAmountOrCode1Choice.Code),
        nameof(UnitOrFaceAmountOrCode1Choice.Code)
    )]
    [IsoId("_SoH21tp-Ed-ak6NoX_4Aeg_361302758")]
    [DisplayName("Unit Or Face Amount Or Code 1 Choice")]
    public abstract record UnitOrFaceAmountOrCode1Choice_ { }
}
