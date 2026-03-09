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
    /// Choice between a type of discount or a type of charge.
    /// </summary>
    [KnownType(typeof(DiscountOrChargeType1Choice.ChargeType))]
    [KnownType(typeof(DiscountOrChargeType1Choice.DiscountType))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DiscountOrChargeType1Choice.ChargeType),nameof(DiscountOrChargeType1Choice.ChargeType))]
    [JsonDerivedType(typeof(DiscountOrChargeType1Choice.DiscountType),nameof(DiscountOrChargeType1Choice.DiscountType))]
    #endif
    [IsoId("_St2yMAEcEeCQm6a_G2yO_w_-1902647807")]
    [DisplayName("Discount Or Charge Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DiscountOrChargeType1Choice_
    #else
    public abstract partial class DiscountOrChargeType1Choice_
    #endif
    {
    }
}
