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
    [KnownType(typeof(UnitOrFaceAmountOrCode1Choice.Unit))]
    [KnownType(typeof(UnitOrFaceAmountOrCode1Choice.FaceAmount))]
    [KnownType(typeof(UnitOrFaceAmountOrCode1Choice.Code))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnitOrFaceAmountOrCode1Choice.Unit),nameof(UnitOrFaceAmountOrCode1Choice.Unit))]
    [JsonDerivedType(typeof(UnitOrFaceAmountOrCode1Choice.FaceAmount),nameof(UnitOrFaceAmountOrCode1Choice.FaceAmount))]
    [JsonDerivedType(typeof(UnitOrFaceAmountOrCode1Choice.Code),nameof(UnitOrFaceAmountOrCode1Choice.Code))]
    #endif
    [IsoId("_SoH21tp-Ed-ak6NoX_4Aeg_361302758")]
    [DisplayName("Unit Or Face Amount Or Code 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitOrFaceAmountOrCode1Choice_
    #else
    public abstract partial class UnitOrFaceAmountOrCode1Choice_
    #endif
    {
    }
}
