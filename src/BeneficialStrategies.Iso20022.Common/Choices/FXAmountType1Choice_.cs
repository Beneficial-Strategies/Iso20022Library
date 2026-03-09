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
    /// Choice of different FX amount types.
    /// </summary>
    [KnownType(typeof(FXAmountType1Choice.Code))]
    [KnownType(typeof(FXAmountType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FXAmountType1Choice.Code),nameof(FXAmountType1Choice.Code))]
    [JsonDerivedType(typeof(FXAmountType1Choice.Proprietary),nameof(FXAmountType1Choice.Proprietary))]
    #endif
    [IsoId("_Z-9lgwN2Ee2-vqzwMUAewg")]
    [DisplayName("FX Amount Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FXAmountType1Choice_
    #else
    public abstract partial class FXAmountType1Choice_
    #endif
    {
    }
}
