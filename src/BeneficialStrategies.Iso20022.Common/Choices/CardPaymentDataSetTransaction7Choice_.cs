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
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction7Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction7Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction7Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction7Choice.AuthorisationResponse))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction7Choice.Completion),nameof(CardPaymentDataSetTransaction7Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction7Choice.Cancellation),nameof(CardPaymentDataSetTransaction7Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction7Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction7Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction7Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction7Choice.AuthorisationResponse))]
    #endif
    [IsoId("_4uNvsdeiEeiJyp_aycJaTw")]
    [DisplayName("Card Payment Data Set Transaction 7 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardPaymentDataSetTransaction7Choice_
    #else
    public abstract partial class CardPaymentDataSetTransaction7Choice_
    #endif
    {
    }
}
