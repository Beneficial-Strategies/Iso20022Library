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
    [KnownType(typeof(CardPaymentDataSetTransaction10Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction10Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction10Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction10Choice.AuthorisationResponse))]
    [KnownType(typeof(CardPaymentDataSetTransaction10Choice.TokenRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction10Choice.TokenResponse))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction10Choice.Completion),nameof(CardPaymentDataSetTransaction10Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction10Choice.Cancellation),nameof(CardPaymentDataSetTransaction10Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction10Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction10Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction10Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction10Choice.AuthorisationResponse))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction10Choice.TokenRequest),nameof(CardPaymentDataSetTransaction10Choice.TokenRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction10Choice.TokenResponse),nameof(CardPaymentDataSetTransaction10Choice.TokenResponse))]
    #endif
    [IsoId("_bZ5hIU0ZEeybj420QgWBkA")]
    [DisplayName("Card Payment Data Set Transaction 10 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardPaymentDataSetTransaction10Choice_
    #else
    public abstract partial class CardPaymentDataSetTransaction10Choice_
    #endif
    {
    }
}
