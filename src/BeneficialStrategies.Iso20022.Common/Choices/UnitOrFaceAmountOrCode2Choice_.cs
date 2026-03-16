// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a unit in decimal number, a face amount in currency and amount or a unit expressed as a code.
    /// </summary>
    [KnownType(typeof(UnitOrFaceAmountOrCode2Choice.Unit))]
    [KnownType(typeof(UnitOrFaceAmountOrCode2Choice.FaceAmount))]
    [KnownType(typeof(UnitOrFaceAmountOrCode2Choice.Code))]
    [JsonDerivedType(
        typeof(UnitOrFaceAmountOrCode2Choice.Unit),
        nameof(UnitOrFaceAmountOrCode2Choice.Unit)
    )]
    [JsonDerivedType(
        typeof(UnitOrFaceAmountOrCode2Choice.FaceAmount),
        nameof(UnitOrFaceAmountOrCode2Choice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(UnitOrFaceAmountOrCode2Choice.Code),
        nameof(UnitOrFaceAmountOrCode2Choice.Code)
    )]
    [IsoId("_e0BT0bqJEemCAOifqHrKJw")]
    [DisplayName("Unit Or Face Amount Or Code 2 Choice")]
    public abstract record UnitOrFaceAmountOrCode2Choice_ { }
}
