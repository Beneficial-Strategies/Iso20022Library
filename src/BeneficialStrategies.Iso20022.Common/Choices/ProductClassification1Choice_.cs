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
    /// Type of relevant product classification.
    /// </summary>
    [KnownType(typeof(ProductClassification1Choice.ClassificationFinancialInstrument))]
    [KnownType(typeof(ProductClassification1Choice.UniqueProductIdentifier))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ProductClassification1Choice.ClassificationFinancialInstrument),nameof(ProductClassification1Choice.ClassificationFinancialInstrument))]
    [JsonDerivedType(typeof(ProductClassification1Choice.UniqueProductIdentifier),nameof(ProductClassification1Choice.UniqueProductIdentifier))]
    #endif
    [IsoId("_POpXwAOGEeWs3sTa9Sj6Lg")]
    [DisplayName("Product Classification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ProductClassification1Choice_
    #else
    public abstract partial class ProductClassification1Choice_
    #endif
    {
    }
}
