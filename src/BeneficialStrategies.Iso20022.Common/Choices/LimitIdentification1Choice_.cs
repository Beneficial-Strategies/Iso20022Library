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
    /// Limit details of one particular limit set by the member and managed by the transaction administrator.
    /// </summary>
    [KnownType(typeof(LimitIdentification1Choice.Current))]
    [KnownType(typeof(LimitIdentification1Choice.Default))]
    [KnownType(typeof(LimitIdentification1Choice.AllCurrent))]
    [KnownType(typeof(LimitIdentification1Choice.AllDefault))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(LimitIdentification1Choice.Current),nameof(LimitIdentification1Choice.Current))]
    [JsonDerivedType(typeof(LimitIdentification1Choice.Default),nameof(LimitIdentification1Choice.Default))]
    [JsonDerivedType(typeof(LimitIdentification1Choice.AllCurrent),nameof(LimitIdentification1Choice.AllCurrent))]
    [JsonDerivedType(typeof(LimitIdentification1Choice.AllDefault),nameof(LimitIdentification1Choice.AllDefault))]
    #endif
    [IsoId("_73bb56MgEeCJ6YNENx4h-w_-184786449")]
    [DisplayName("Limit Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record LimitIdentification1Choice_
    #else
    public abstract partial class LimitIdentification1Choice_
    #endif
    {
    }
}
