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
    /// Set of elements defining the balance details.
    /// </summary>
    [KnownType(typeof(BalanceType2Choice.Code))]
    [KnownType(typeof(BalanceType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceType2Choice.Code),nameof(BalanceType2Choice.Code))]
    [JsonDerivedType(typeof(BalanceType2Choice.Proprietary),nameof(BalanceType2Choice.Proprietary))]
    #endif
    [IsoId("_RcH9wtp-Ed-ak6NoX_4Aeg_1127274775")]
    [DisplayName("Balance Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceType2Choice_
    #else
    public abstract partial class BalanceType2Choice_
    #endif
    {
    }
}
