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
    [KnownType(typeof(UnitOrFaceAmount1Choice.Unit))]
    [KnownType(typeof(UnitOrFaceAmount1Choice.FaceAmount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(UnitOrFaceAmount1Choice.Unit),nameof(UnitOrFaceAmount1Choice.Unit))]
    [JsonDerivedType(typeof(UnitOrFaceAmount1Choice.FaceAmount),nameof(UnitOrFaceAmount1Choice.FaceAmount))]
    #endif
    [IsoId("_SoRAwdp-Ed-ak6NoX_4Aeg_-514701328")]
    [DisplayName("Unit Or Face Amount 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record UnitOrFaceAmount1Choice_
    #else
    public abstract partial class UnitOrFaceAmount1Choice_
    #endif
    {
    }
}
