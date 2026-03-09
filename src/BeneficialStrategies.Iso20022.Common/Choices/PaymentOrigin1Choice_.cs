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
    /// Specifies the format under which the payment that generated the entry was transmitted.
    /// </summary>
    [KnownType(typeof(PaymentOrigin1Choice.FINMessageType))]
    [KnownType(typeof(PaymentOrigin1Choice.XMLMessageName))]
    [KnownType(typeof(PaymentOrigin1Choice.Proprietary))]
    [KnownType(typeof(PaymentOrigin1Choice.Instrument))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PaymentOrigin1Choice.FINMessageType),nameof(PaymentOrigin1Choice.FINMessageType))]
    [JsonDerivedType(typeof(PaymentOrigin1Choice.XMLMessageName),nameof(PaymentOrigin1Choice.XMLMessageName))]
    [JsonDerivedType(typeof(PaymentOrigin1Choice.Proprietary),nameof(PaymentOrigin1Choice.Proprietary))]
    [JsonDerivedType(typeof(PaymentOrigin1Choice.Instrument),nameof(PaymentOrigin1Choice.Instrument))]
    #endif
    [IsoId("_RIwV1Np-Ed-ak6NoX_4Aeg_1623377139")]
    [DisplayName("Payment Origin 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PaymentOrigin1Choice_
    #else
    public abstract partial class PaymentOrigin1Choice_
    #endif
    {
    }
}
