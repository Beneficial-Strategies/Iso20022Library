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
    /// Specifies the unique identification of an account as assigned by the account servicer.
    /// </summary>
    [KnownType(typeof(CashAccountIdentification8Choice.Other))]
    [KnownType(typeof(CashAccountIdentification8Choice.IBAN))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CashAccountIdentification8Choice.Other),nameof(CashAccountIdentification8Choice.Other))]
    [JsonDerivedType(typeof(CashAccountIdentification8Choice.IBAN),nameof(CashAccountIdentification8Choice.IBAN))]
    #endif
    [IsoId("_lFOOAbfLEeuDTOqGwU_8EQ")]
    [DisplayName("Cash Account Identification 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashAccountIdentification8Choice_
    #else
    public abstract partial class CashAccountIdentification8Choice_
    #endif
    {
    }
}
