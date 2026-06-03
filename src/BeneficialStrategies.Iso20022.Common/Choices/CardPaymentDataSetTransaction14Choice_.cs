// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction14Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction14Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction14Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction14Choice.AuthorisationResponse))]
    [KnownType(typeof(CardPaymentDataSetTransaction14Choice.TokenRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction14Choice.TokenResponse))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction14Choice.Completion), nameof(CardPaymentDataSetTransaction14Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction14Choice.Cancellation), nameof(CardPaymentDataSetTransaction14Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction14Choice.AuthorisationRequest), nameof(CardPaymentDataSetTransaction14Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction14Choice.AuthorisationResponse), nameof(CardPaymentDataSetTransaction14Choice.AuthorisationResponse))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction14Choice.TokenRequest), nameof(CardPaymentDataSetTransaction14Choice.TokenRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction14Choice.TokenResponse), nameof(CardPaymentDataSetTransaction14Choice.TokenResponse))]
    [IsoId("_tJK2AbYJEfCUZfsQO4rYeA")]
    [DisplayName("CardPaymentDataSetTransaction14Choice")]
    public abstract record CardPaymentDataSetTransaction14Choice_ { }
}
