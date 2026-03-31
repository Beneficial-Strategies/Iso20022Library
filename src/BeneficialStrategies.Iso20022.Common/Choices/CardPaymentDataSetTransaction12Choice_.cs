// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card Payment Data Set Transaction12Choice.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction12Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction12Choice.AuthorisationResponse))]
    [KnownType(typeof(CardPaymentDataSetTransaction12Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction12Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction12Choice.TokenRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction12Choice.TokenResponse))]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction12Choice.AuthorisationRequest),
        nameof(CardPaymentDataSetTransaction12Choice.AuthorisationRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction12Choice.AuthorisationResponse),
        nameof(CardPaymentDataSetTransaction12Choice.AuthorisationResponse)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction12Choice.Cancellation),
        nameof(CardPaymentDataSetTransaction12Choice.Cancellation)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction12Choice.Completion),
        nameof(CardPaymentDataSetTransaction12Choice.Completion)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction12Choice.TokenRequest),
        nameof(CardPaymentDataSetTransaction12Choice.TokenRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction12Choice.TokenResponse),
        nameof(CardPaymentDataSetTransaction12Choice.TokenResponse)
    )]
    [IsoId("_sgQV0ZQvEe6HYLAajyhWIQ")]
    [DisplayName("Card Payment Data Set Transaction12Choice")]
    public abstract record CardPaymentDataSetTransaction12Choice_ { }
}
