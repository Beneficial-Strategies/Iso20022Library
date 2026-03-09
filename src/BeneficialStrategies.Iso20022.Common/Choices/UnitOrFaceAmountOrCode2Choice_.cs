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
    [KnownType(typeof(UnitOrFaceAmountOrCode2Choice.Unit))]
    [KnownType(typeof(UnitOrFaceAmountOrCode2Choice.FaceAmount))]
    [KnownType(typeof(UnitOrFaceAmountOrCode2Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnitOrFaceAmountOrCode2Choice.Unit),nameof(UnitOrFaceAmountOrCode2Choice.Unit))]
    [JsonDerivedType(typeof(UnitOrFaceAmountOrCode2Choice.FaceAmount),nameof(UnitOrFaceAmountOrCode2Choice.FaceAmount))]
    [JsonDerivedType(typeof(UnitOrFaceAmountOrCode2Choice.Code),nameof(UnitOrFaceAmountOrCode2Choice.Code))]
    #endif
    [IsoId("_e0BT0bqJEemCAOifqHrKJw")]
    [DisplayName("Unit Or Face Amount Or Code 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitOrFaceAmountOrCode2Choice_
    #else
    public abstract partial class UnitOrFaceAmountOrCode2Choice_
    #endif
    {
    }
}
