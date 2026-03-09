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
    [KnownType(typeof(CardPaymentDataSetTransaction11Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction11Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction11Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction11Choice.AuthorisationResponse))]
    [KnownType(typeof(CardPaymentDataSetTransaction11Choice.TokenRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction11Choice.TokenResponse))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction11Choice.Completion),nameof(CardPaymentDataSetTransaction11Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction11Choice.Cancellation),nameof(CardPaymentDataSetTransaction11Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction11Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction11Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction11Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction11Choice.AuthorisationResponse))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction11Choice.TokenRequest),nameof(CardPaymentDataSetTransaction11Choice.TokenRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction11Choice.TokenResponse),nameof(CardPaymentDataSetTransaction11Choice.TokenResponse))]
    #endif
    [IsoId("_1rUJMXJCEe299ZbWCkdR_w")]
    [DisplayName("Card Payment Data Set Transaction 11 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardPaymentDataSetTransaction11Choice_
    #else
    public abstract partial class CardPaymentDataSetTransaction11Choice_
    #endif
    {
    }
}
