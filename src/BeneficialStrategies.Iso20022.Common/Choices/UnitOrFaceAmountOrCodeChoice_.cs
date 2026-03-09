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
    /// Choice between a unit in decimal number, a face amount in currency and amount or a unit expressed as a code.
    /// </summary>
    [KnownType(typeof(UnitOrFaceAmountOrCodeChoice.Unit))]
    [KnownType(typeof(UnitOrFaceAmountOrCodeChoice.FaceAmount))]
    [KnownType(typeof(UnitOrFaceAmountOrCodeChoice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnitOrFaceAmountOrCodeChoice.Unit),nameof(UnitOrFaceAmountOrCodeChoice.Unit))]
    [JsonDerivedType(typeof(UnitOrFaceAmountOrCodeChoice.FaceAmount),nameof(UnitOrFaceAmountOrCodeChoice.FaceAmount))]
    [JsonDerivedType(typeof(UnitOrFaceAmountOrCodeChoice.Code),nameof(UnitOrFaceAmountOrCodeChoice.Code))]
    #endif
    [IsoId("_SokixNp-Ed-ak6NoX_4Aeg_1106804694")]
    [DisplayName("Unit Or Face Amount Or Code Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitOrFaceAmountOrCodeChoice_
    #else
    public abstract partial class UnitOrFaceAmountOrCodeChoice_
    #endif
    {
    }
}
