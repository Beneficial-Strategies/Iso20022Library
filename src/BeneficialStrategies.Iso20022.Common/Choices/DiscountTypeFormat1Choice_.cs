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
    /// Choice between a standard code or a proprietary code for specifying the type of discount.
    /// </summary>
    [KnownType(typeof(DiscountTypeFormat1Choice.Code))]
    [KnownType(typeof(DiscountTypeFormat1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(DiscountTypeFormat1Choice.Code),nameof(DiscountTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(DiscountTypeFormat1Choice.Proprietary),nameof(DiscountTypeFormat1Choice.Proprietary))]
    #endif
    [IsoId("_SumZFQEcEeCQm6a_G2yO_w_1636227092")]
    [DisplayName("Discount Type Format 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record DiscountTypeFormat1Choice_
    #else
    public abstract partial class DiscountTypeFormat1Choice_
    #endif
    {
    }
}
