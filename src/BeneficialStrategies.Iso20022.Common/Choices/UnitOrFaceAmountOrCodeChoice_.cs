// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a unit in decimal number, a face amount in currency and amount or a unit expressed as a code.
    /// </summary>
    [KnownType(typeof(UnitOrFaceAmountOrCodeChoice.Unit))]
    [KnownType(typeof(UnitOrFaceAmountOrCodeChoice.FaceAmount))]
    [KnownType(typeof(UnitOrFaceAmountOrCodeChoice.Code))]
    [JsonDerivedType(
        typeof(UnitOrFaceAmountOrCodeChoice.Unit),
        nameof(UnitOrFaceAmountOrCodeChoice.Unit)
    )]
    [JsonDerivedType(
        typeof(UnitOrFaceAmountOrCodeChoice.FaceAmount),
        nameof(UnitOrFaceAmountOrCodeChoice.FaceAmount)
    )]
    [JsonDerivedType(
        typeof(UnitOrFaceAmountOrCodeChoice.Code),
        nameof(UnitOrFaceAmountOrCodeChoice.Code)
    )]
    [IsoId("_SokixNp-Ed-ak6NoX_4Aeg_1106804694")]
    [DisplayName("Unit Or Face Amount Or Code Choice")]
    public abstract record UnitOrFaceAmountOrCodeChoice_ { }
}
