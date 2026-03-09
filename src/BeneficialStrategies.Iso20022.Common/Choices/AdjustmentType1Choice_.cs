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
    /// Specifies the type of adjustment applied to the amount of goods/services by means of a code or free text.
    /// </summary>
    [KnownType(typeof(AdjustmentType1Choice.Type))]
    [KnownType(typeof(AdjustmentType1Choice.OtherAdjustmentType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AdjustmentType1Choice.Type),nameof(AdjustmentType1Choice.Type))]
    [JsonDerivedType(typeof(AdjustmentType1Choice.OtherAdjustmentType),nameof(AdjustmentType1Choice.OtherAdjustmentType))]
    #endif
    [IsoId("_HQHgwBrXEeOVR9VN6fAMUg")]
    [DisplayName("Adjustment Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AdjustmentType1Choice_
    #else
    public abstract partial class AdjustmentType1Choice_
    #endif
    {
    }
}
