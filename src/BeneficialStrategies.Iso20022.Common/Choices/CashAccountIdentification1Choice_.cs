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
    [KnownType(typeof(CashAccountIdentification1Choice.IBAN))]
    [KnownType(typeof(CashAccountIdentification1Choice.BBAN))]
    [KnownType(typeof(CashAccountIdentification1Choice.UPIC))]
    [KnownType(typeof(CashAccountIdentification1Choice.DomesticAccount))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CashAccountIdentification1Choice.IBAN),nameof(CashAccountIdentification1Choice.IBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification1Choice.BBAN),nameof(CashAccountIdentification1Choice.BBAN))]
    [JsonDerivedType(typeof(CashAccountIdentification1Choice.UPIC),nameof(CashAccountIdentification1Choice.UPIC))]
    [JsonDerivedType(typeof(CashAccountIdentification1Choice.DomesticAccount),nameof(CashAccountIdentification1Choice.DomesticAccount))]
    #endif
    [IsoId("_PdwzpNp-Ed-ak6NoX_4Aeg_2060838761")]
    [DisplayName("Cash Account Identification 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashAccountIdentification1Choice_
    #else
    public abstract partial class CashAccountIdentification1Choice_
    #endif
    {
    }
}
