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
    /// Specifies type of margin models used by central counterparties.
    /// </summary>
    [KnownType(typeof(ModelType1Choice.Code))]
    [KnownType(typeof(ModelType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ModelType1Choice.Code),nameof(ModelType1Choice.Code))]
    [JsonDerivedType(typeof(ModelType1Choice.Proprietary),nameof(ModelType1Choice.Proprietary))]
    #endif
    [IsoId("_jxanEI2GEeet3cKIYK84nw")]
    [DisplayName("Model Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ModelType1Choice_
    #else
    public abstract partial class ModelType1Choice_
    #endif
    {
    }
}
