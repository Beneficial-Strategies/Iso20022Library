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
    /// Unique identifier of an account, as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification2Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CashAccountIdentification2Choice.IBAN),nameof(CashAccountIdentification2Choice.IBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification2Choice.Proprietary),nameof(CashAccountIdentification2Choice.Proprietary))]
    #endif
    [IsoId("_Pd6koNp-Ed-ak6NoX_4Aeg_252858102")]
    [DisplayName("Cash Account Identification 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashAccountIdentification2Choice_
    #else
    public abstract partial class CashAccountIdentification2Choice_
    #endif
    {
    }
}
