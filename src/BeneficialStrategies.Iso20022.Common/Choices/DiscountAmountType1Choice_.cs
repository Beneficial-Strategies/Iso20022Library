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
    /// Specifies the amount type.
    /// </summary>
    [KnownType(typeof(DiscountAmountType1Choice.Code))]
    [KnownType(typeof(DiscountAmountType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DiscountAmountType1Choice.Code),nameof(DiscountAmountType1Choice.Code))]
    [JsonDerivedType(typeof(DiscountAmountType1Choice.Proprietary),nameof(DiscountAmountType1Choice.Proprietary))]
    #endif
    [IsoId("_tlhp9FkyEeGeoaLUQk__nA_1969856985")]
    [DisplayName("Discount Amount Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DiscountAmountType1Choice_
    #else
    public abstract partial class DiscountAmountType1Choice_
    #endif
    {
    }
}
