// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction9Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction9Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction9Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction9Choice.AuthorisationResponse))]
    [KnownType(typeof(CardPaymentDataSetTransaction9Choice.TokenRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction9Choice.TokenResponse))]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction9Choice.Completion),
        nameof(CardPaymentDataSetTransaction9Choice.Completion)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction9Choice.Cancellation),
        nameof(CardPaymentDataSetTransaction9Choice.Cancellation)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction9Choice.AuthorisationRequest),
        nameof(CardPaymentDataSetTransaction9Choice.AuthorisationRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction9Choice.AuthorisationResponse),
        nameof(CardPaymentDataSetTransaction9Choice.AuthorisationResponse)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction9Choice.TokenRequest),
        nameof(CardPaymentDataSetTransaction9Choice.TokenRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction9Choice.TokenResponse),
        nameof(CardPaymentDataSetTransaction9Choice.TokenResponse)
    )]
    [IsoId("_KJfv0S5BEeunNvJlR_vCbg")]
    [DisplayName("Card Payment Data Set Transaction 9 Choice")]
    public abstract record CardPaymentDataSetTransaction9Choice_ { }
}
