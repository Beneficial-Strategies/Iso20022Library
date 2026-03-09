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
    /// Choice between a cash account, a charges account or a tax account.
    /// </summary>
    [KnownType(typeof(Account8Choice.CashAccount))]
    [KnownType(typeof(Account8Choice.ChargesAccount))]
    [KnownType(typeof(Account8Choice.TaxAccount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Account8Choice.CashAccount),nameof(Account8Choice.CashAccount))]
    [JsonDerivedType(typeof(Account8Choice.ChargesAccount),nameof(Account8Choice.ChargesAccount))]
    [JsonDerivedType(typeof(Account8Choice.TaxAccount),nameof(Account8Choice.TaxAccount))]
    #endif
    [IsoId("_Q4z1Udp-Ed-ak6NoX_4Aeg_-2028069382")]
    [DisplayName("Account 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Account8Choice_
    #else
    public abstract partial class Account8Choice_
    #endif
    {
    }
}
