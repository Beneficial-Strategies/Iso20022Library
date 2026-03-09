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
    /// Specifies the balance type.
    /// </summary>
    [KnownType(typeof(BalanceType5Choice.Code))]
    [KnownType(typeof(BalanceType5Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceType5Choice.Code),nameof(BalanceType5Choice.Code))]
    [JsonDerivedType(typeof(BalanceType5Choice.Proprietary),nameof(BalanceType5Choice.Proprietary))]
    #endif
    [IsoId("_SYxMMNp-Ed-ak6NoX_4Aeg_1163104802")]
    [DisplayName("Balance Type 5 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceType5Choice_
    #else
    public abstract partial class BalanceType5Choice_
    #endif
    {
    }
}
