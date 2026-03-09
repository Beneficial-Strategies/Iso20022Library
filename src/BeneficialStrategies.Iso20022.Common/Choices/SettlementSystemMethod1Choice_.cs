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
    /// Choice of format for the settlement system/method.
    /// </summary>
    [KnownType(typeof(SettlementSystemMethod1Choice.Code))]
    [KnownType(typeof(SettlementSystemMethod1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SettlementSystemMethod1Choice.Code),nameof(SettlementSystemMethod1Choice.Code))]
    [JsonDerivedType(typeof(SettlementSystemMethod1Choice.Proprietary),nameof(SettlementSystemMethod1Choice.Proprietary))]
    #endif
    [IsoId("_QvkZxNp-Ed-ak6NoX_4Aeg_-1971430733")]
    [DisplayName("Settlement System Method 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SettlementSystemMethod1Choice_
    #else
    public abstract partial class SettlementSystemMethod1Choice_
    #endif
    {
    }
}
