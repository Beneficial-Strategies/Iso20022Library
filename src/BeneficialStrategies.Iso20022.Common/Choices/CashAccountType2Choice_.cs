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
    /// Nature or use of the account.
    /// </summary>
    [KnownType(typeof(CashAccountType2Choice.Code))]
    [KnownType(typeof(CashAccountType2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CashAccountType2Choice.Code),nameof(CashAccountType2Choice.Code))]
    [JsonDerivedType(typeof(CashAccountType2Choice.Proprietary),nameof(CashAccountType2Choice.Proprietary))]
    #endif
    [IsoId("_sb6WgFkyEeGeoaLUQk__nA_1768299331")]
    [DisplayName("Cash Account Type 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashAccountType2Choice_
    #else
    public abstract partial class CashAccountType2Choice_
    #endif
    {
    }
}
