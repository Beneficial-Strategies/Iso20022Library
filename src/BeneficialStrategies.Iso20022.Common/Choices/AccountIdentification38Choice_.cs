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
    /// Unique identification of the securities account or the cash account owned by the customer.
    /// </summary>
    [KnownType(typeof(AccountIdentification38Choice.SecuritiesAccountIdentification))]
    [KnownType(typeof(AccountIdentification38Choice.CashAccountIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification38Choice.SecuritiesAccountIdentification),nameof(AccountIdentification38Choice.SecuritiesAccountIdentification))]
    [JsonDerivedType(typeof(AccountIdentification38Choice.CashAccountIdentification),nameof(AccountIdentification38Choice.CashAccountIdentification))]
    #endif
    [IsoId("_ma_Aj-F6EeWCAvUNsZ5u6g")]
    [DisplayName("Account Identification 38 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification38Choice_
    #else
    public abstract partial class AccountIdentification38Choice_
    #endif
    {
    }
}
