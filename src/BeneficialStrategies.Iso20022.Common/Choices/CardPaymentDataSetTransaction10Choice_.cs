// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction10Choice.Completion),
        nameof(CardPaymentDataSetTransaction10Choice.Completion)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction10Choice.Cancellation),
        nameof(CardPaymentDataSetTransaction10Choice.Cancellation)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction10Choice.AuthorisationRequest),
        nameof(CardPaymentDataSetTransaction10Choice.AuthorisationRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction10Choice.AuthorisationResponse),
        nameof(CardPaymentDataSetTransaction10Choice.AuthorisationResponse)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction10Choice.TokenRequest),
        nameof(CardPaymentDataSetTransaction10Choice.TokenRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction10Choice.TokenResponse),
        nameof(CardPaymentDataSetTransaction10Choice.TokenResponse)
    )]
    [IsoId("_bZ5hIU0ZEeybj420QgWBkA")]
    [DisplayName("Card Payment Data Set Transaction 10 Choice")]
    public abstract record CardPaymentDataSetTransaction10Choice_ { }
}
