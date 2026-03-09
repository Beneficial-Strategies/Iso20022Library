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
    /// Specifies the choice between the major categories of financial instruments.
    /// </summary>
    [KnownType(typeof(Product1Choice.Derivative))]
    [KnownType(typeof(Product1Choice.SecuritiesFinancingTransaction))]
    [KnownType(typeof(Product1Choice.Security))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Product1Choice.Derivative),nameof(Product1Choice.Derivative))]
    [JsonDerivedType(typeof(Product1Choice.SecuritiesFinancingTransaction),nameof(Product1Choice.SecuritiesFinancingTransaction))]
    [JsonDerivedType(typeof(Product1Choice.Security),nameof(Product1Choice.Security))]
    #endif
    [IsoId("_AS4VYLVPEeadLcJesEbkTQ")]
    [DisplayName("Product 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Product1Choice_
    #else
    public abstract partial class Product1Choice_
    #endif
    {
    }
}
