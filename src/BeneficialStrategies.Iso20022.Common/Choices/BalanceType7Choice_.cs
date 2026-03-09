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
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(BalanceType7Choice.Code))]
    [KnownType(typeof(BalanceType7Choice.Proprietary))]
    [KnownType(typeof(BalanceType7Choice.Account))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceType7Choice.Code),nameof(BalanceType7Choice.Code))]
    [JsonDerivedType(typeof(BalanceType7Choice.Proprietary),nameof(BalanceType7Choice.Proprietary))]
    [JsonDerivedType(typeof(BalanceType7Choice.Account),nameof(BalanceType7Choice.Account))]
    #endif
    [IsoId("_nAhTV_NBEeCuA5Tr22BnwA_51741931")]
    [DisplayName("Balance Type 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceType7Choice_
    #else
    public abstract partial class BalanceType7Choice_
    #endif
    {
    }
}
