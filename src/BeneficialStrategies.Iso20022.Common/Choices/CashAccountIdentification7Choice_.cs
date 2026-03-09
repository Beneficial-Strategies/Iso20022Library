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
    /// Choice between formats for the identification of a cash account.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification7Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification7Choice.BBAN))]
    [KnownType(typeof(CashAccountIdentification7Choice.UPIC))]
    [KnownType(typeof(CashAccountIdentification7Choice.DomesticAccount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CashAccountIdentification7Choice.IBAN),nameof(CashAccountIdentification7Choice.IBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification7Choice.BBAN),nameof(CashAccountIdentification7Choice.BBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification7Choice.UPIC),nameof(CashAccountIdentification7Choice.UPIC))]
    [JsonDerivedType(typeof(CashAccountIdentification7Choice.DomesticAccount),nameof(CashAccountIdentification7Choice.DomesticAccount))]
    #endif
    [IsoId("_oxTyQeWbEeevU7McUP3D1w")]
    [DisplayName("Cash Account Identification 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashAccountIdentification7Choice_
    #else
    public abstract partial class CashAccountIdentification7Choice_
    #endif
    {
    }
}
