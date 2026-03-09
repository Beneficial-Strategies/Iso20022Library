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
    [KnownType(typeof(BalanceType4Choice.Code))]
    [KnownType(typeof(BalanceType4Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceType4Choice.Code),nameof(BalanceType4Choice.Code))]
    [JsonDerivedType(typeof(BalanceType4Choice.Proprietary),nameof(BalanceType4Choice.Proprietary))]
    #endif
    [IsoId("_RcRuwNp-Ed-ak6NoX_4Aeg_-1171282176")]
    [DisplayName("Balance Type 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceType4Choice_
    #else
    public abstract partial class BalanceType4Choice_
    #endif
    {
    }
}
