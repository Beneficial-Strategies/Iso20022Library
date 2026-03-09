// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a unit in decimal number or a face amount in currency and amount.
    /// </summary>
    [KnownType(typeof(UnitOrFaceAmountChoice.Unit))]
    [KnownType(typeof(UnitOrFaceAmountChoice.FaceAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnitOrFaceAmountChoice.Unit),nameof(UnitOrFaceAmountChoice.Unit))]
    [JsonDerivedType(typeof(UnitOrFaceAmountChoice.FaceAmount),nameof(UnitOrFaceAmountChoice.FaceAmount))]
    #endif
    [IsoId("_SoH20dp-Ed-ak6NoX_4Aeg_144255606")]
    [DisplayName("Unit Or Face Amount Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitOrFaceAmountChoice_
    #else
    public abstract partial class UnitOrFaceAmountChoice_
    #endif
    {
    }
}
