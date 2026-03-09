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
    /// Specifies the balance details.
    /// </summary>
    [KnownType(typeof(BalanceType8Choice.Code))]
    [KnownType(typeof(BalanceType8Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceType8Choice.Code),nameof(BalanceType8Choice.Code))]
    [JsonDerivedType(typeof(BalanceType8Choice.Proprietary),nameof(BalanceType8Choice.Proprietary))]
    #endif
    [IsoId("_74nutaMgEeCJ6YNENx4h-w_-431996980")]
    [DisplayName("Balance Type 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceType8Choice_
    #else
    public abstract partial class BalanceType8Choice_
    #endif
    {
    }
}
