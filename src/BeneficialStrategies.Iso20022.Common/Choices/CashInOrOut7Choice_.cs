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
    /// Choice of a payment instrument for the cash-in flow or cash-out flow.
    /// </summary>
    [KnownType(typeof(CashInOrOut7Choice.CashInPaymentInstrument))]
    [KnownType(typeof(CashInOrOut7Choice.CashOutPaymentInstrument))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CashInOrOut7Choice.CashInPaymentInstrument),nameof(CashInOrOut7Choice.CashInPaymentInstrument))]
    [JsonDerivedType(typeof(CashInOrOut7Choice.CashOutPaymentInstrument),nameof(CashInOrOut7Choice.CashOutPaymentInstrument))]
    #endif
    [IsoId("_3a23dTbsEead9bDRE_1DAQ")]
    [DisplayName("Cash In Or Out 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashInOrOut7Choice_
    #else
    public abstract partial class CashInOrOut7Choice_
    #endif
    {
    }
}
