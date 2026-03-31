// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card Payment Data Set Transaction13Choice.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction13Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction13Choice.AuthorisationResponse))]
    [KnownType(typeof(CardPaymentDataSetTransaction13Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction13Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction13Choice.TokenRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction13Choice.TokenResponse))]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction13Choice.AuthorisationRequest),
        nameof(CardPaymentDataSetTransaction13Choice.AuthorisationRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction13Choice.AuthorisationResponse),
        nameof(CardPaymentDataSetTransaction13Choice.AuthorisationResponse)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction13Choice.Cancellation),
        nameof(CardPaymentDataSetTransaction13Choice.Cancellation)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction13Choice.Completion),
        nameof(CardPaymentDataSetTransaction13Choice.Completion)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction13Choice.TokenRequest),
        nameof(CardPaymentDataSetTransaction13Choice.TokenRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction13Choice.TokenResponse),
        nameof(CardPaymentDataSetTransaction13Choice.TokenResponse)
    )]
    [IsoId("_nD8TIaE2Ee-MRKYsaX6JDg")]
    [DisplayName("Card Payment Data Set Transaction13Choice")]
    public abstract record CardPaymentDataSetTransaction13Choice_ { }
}
