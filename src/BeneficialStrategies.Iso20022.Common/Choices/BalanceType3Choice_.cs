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
    [KnownType(typeof(BalanceType3Choice.Code))]
    [KnownType(typeof(BalanceType3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(BalanceType3Choice.Code),nameof(BalanceType3Choice.Code))]
    [JsonDerivedType(typeof(BalanceType3Choice.Proprietary),nameof(BalanceType3Choice.Proprietary))]
    #endif
    [IsoId("_RcRuw9p-Ed-ak6NoX_4Aeg_-1428945866")]
    [DisplayName("Balance Type 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record BalanceType3Choice_
    #else
    public abstract partial class BalanceType3Choice_
    #endif
    {
    }
}
