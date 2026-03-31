// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

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
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction11Choice.Completion),
        nameof(CardPaymentDataSetTransaction11Choice.Completion)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction11Choice.Cancellation),
        nameof(CardPaymentDataSetTransaction11Choice.Cancellation)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction11Choice.AuthorisationRequest),
        nameof(CardPaymentDataSetTransaction11Choice.AuthorisationRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction11Choice.AuthorisationResponse),
        nameof(CardPaymentDataSetTransaction11Choice.AuthorisationResponse)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction11Choice.TokenRequest),
        nameof(CardPaymentDataSetTransaction11Choice.TokenRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction11Choice.TokenResponse),
        nameof(CardPaymentDataSetTransaction11Choice.TokenResponse)
    )]
    [IsoId("_1rUJMXJCEe299ZbWCkdR_w")]
    [DisplayName("Card Payment Data Set Transaction 11 Choice")]
    public abstract record CardPaymentDataSetTransaction11Choice_ { }
}
