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
    [KnownType(typeof(Account9Choice.CashAccount))]
    [KnownType(typeof(Account9Choice.ChargesAccount))]
    [KnownType(typeof(Account9Choice.TaxAccount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(Account9Choice.CashAccount),nameof(Account9Choice.CashAccount))]
    [JsonDerivedType(typeof(Account9Choice.ChargesAccount),nameof(Account9Choice.ChargesAccount))]
    [JsonDerivedType(typeof(Account9Choice.TaxAccount),nameof(Account9Choice.TaxAccount))]
    #endif
    [IsoId("_XY2a49p-Ed-ak6NoX_4Aeg_-2005416600")]
    [DisplayName("Account 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record Account9Choice_
    #else
    public abstract partial class Account9Choice_
    #endif
    {
    }
}
