// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction3Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction3Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction3Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction3Choice.AuthorisationResponse))]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction3Choice.Completion),
        nameof(CardPaymentDataSetTransaction3Choice.Completion)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction3Choice.Cancellation),
        nameof(CardPaymentDataSetTransaction3Choice.Cancellation)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction3Choice.AuthorisationRequest),
        nameof(CardPaymentDataSetTransaction3Choice.AuthorisationRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction3Choice.AuthorisationResponse),
        nameof(CardPaymentDataSetTransaction3Choice.AuthorisationResponse)
    )]
    [IsoId("_EmW5UWmJEeS7iYydEtv3Ug")]
    [DisplayName("Card Payment Data Set Transaction 3 Choice")]
    public abstract record CardPaymentDataSetTransaction3Choice_ { }
}
