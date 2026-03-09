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
    /// Indication whether reused value is actual or estimated.
    /// </summary>
    [KnownType(typeof(ReuseValue1Choice.Actual))]
    [KnownType(typeof(ReuseValue1Choice.Estimated))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(ReuseValue1Choice.Actual),nameof(ReuseValue1Choice.Actual))]
    [JsonDerivedType(typeof(ReuseValue1Choice.Estimated),nameof(ReuseValue1Choice.Estimated))]
    #endif
    [IsoId("_MSGu8IxnEeap1-whlAlpOw")]
    [DisplayName("Reuse Value 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record ReuseValue1Choice_
    #else
    public abstract partial class ReuseValue1Choice_
    #endif
    {
    }
}
