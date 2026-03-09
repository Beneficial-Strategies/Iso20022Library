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
    [KnownType(typeof(CashInOrOut6Choice.CashInPaymentInstrument))]
    [KnownType(typeof(CashInOrOut6Choice.CashOutPaymentInstrument))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CashInOrOut6Choice.CashInPaymentInstrument),nameof(CashInOrOut6Choice.CashInPaymentInstrument))]
    [JsonDerivedType(typeof(CashInOrOut6Choice.CashOutPaymentInstrument),nameof(CashInOrOut6Choice.CashOutPaymentInstrument))]
    #endif
    [IsoId("_SBhw6Np-Ed-ak6NoX_4Aeg_885994005")]
    [DisplayName("Cash In Or Out 6 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CashInOrOut6Choice_
    #else
    public abstract partial class CashInOrOut6Choice_
    #endif
    {
    }
}
