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
    /// Choice between the identification of a cash or securities account.
    /// </summary>
    [KnownType(typeof(AccountIdentification2Choice.CashAccountIdentification))]
    [KnownType(typeof(AccountIdentification2Choice.SecuritiesAccountIdentification))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(AccountIdentification2Choice.CashAccountIdentification),nameof(AccountIdentification2Choice.CashAccountIdentification))]
    [JsonDerivedType(typeof(AccountIdentification2Choice.SecuritiesAccountIdentification),nameof(AccountIdentification2Choice.SecuritiesAccountIdentification))]
    #endif
    [IsoId("_Rjkpl9p-Ed-ak6NoX_4Aeg_63905637")]
    [DisplayName("Account Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record AccountIdentification2Choice_
    #else
    public abstract partial class AccountIdentification2Choice_
    #endif
    {
    }
}
