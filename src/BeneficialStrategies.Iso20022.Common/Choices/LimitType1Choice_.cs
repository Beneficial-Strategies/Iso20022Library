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
    /// Nature of the risk management limit defined as a choice between a coded list or a proprietary limit.
    /// </summary>
    [KnownType(typeof(LimitType1Choice.Code))]
    [KnownType(typeof(LimitType1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LimitType1Choice.Code),nameof(LimitType1Choice.Code))]
    [JsonDerivedType(typeof(LimitType1Choice.Proprietary),nameof(LimitType1Choice.Proprietary))]
    #endif
    [IsoId("_79FX8KMgEeCJ6YNENx4h-w_1397757128")]
    [DisplayName("Limit Type 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LimitType1Choice_
    #else
    public abstract partial class LimitType1Choice_
    #endif
    {
    }
}
