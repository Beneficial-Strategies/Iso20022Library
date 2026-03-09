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
    /// Specifies that the category of a product may be indicated by a code or by free text.
    /// </summary>
    [KnownType(typeof(ProductCategory1Choice.StructuredProductCategory))]
    [KnownType(typeof(ProductCategory1Choice.OtherProductCategory))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProductCategory1Choice.StructuredProductCategory),nameof(ProductCategory1Choice.StructuredProductCategory))]
    [JsonDerivedType(typeof(ProductCategory1Choice.OtherProductCategory),nameof(ProductCategory1Choice.OtherProductCategory))]
    #endif
    [IsoId("_RbrR1tp-Ed-ak6NoX_4Aeg_-1773751928")]
    [DisplayName("Product Category 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProductCategory1Choice_
    #else
    public abstract partial class ProductCategory1Choice_
    #endif
    {
    }
}
