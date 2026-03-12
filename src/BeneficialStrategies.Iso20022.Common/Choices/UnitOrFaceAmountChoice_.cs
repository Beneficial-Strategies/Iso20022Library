// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a unit in decimal number or a face amount in currency and amount.
    /// </summary>
    [KnownType(typeof(UnitOrFaceAmountChoice.Unit))]
    [KnownType(typeof(UnitOrFaceAmountChoice.FaceAmount))]
    [JsonDerivedType(typeof(UnitOrFaceAmountChoice.Unit),nameof(UnitOrFaceAmountChoice.Unit))]
    [JsonDerivedType(typeof(UnitOrFaceAmountChoice.FaceAmount),nameof(UnitOrFaceAmountChoice.FaceAmount))]
    [IsoId("_SoH20dp-Ed-ak6NoX_4Aeg_144255606")]
    [DisplayName("Unit Or Face Amount Choice")]
    public abstract partial record UnitOrFaceAmountChoice_
    {
    }
}
