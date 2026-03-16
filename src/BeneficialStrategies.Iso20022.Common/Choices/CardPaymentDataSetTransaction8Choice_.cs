// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction8Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction8Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction8Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction8Choice.AuthorisationResponse))]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction8Choice.Completion),
        nameof(CardPaymentDataSetTransaction8Choice.Completion)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction8Choice.Cancellation),
        nameof(CardPaymentDataSetTransaction8Choice.Cancellation)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction8Choice.AuthorisationRequest),
        nameof(CardPaymentDataSetTransaction8Choice.AuthorisationRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction8Choice.AuthorisationResponse),
        nameof(CardPaymentDataSetTransaction8Choice.AuthorisationResponse)
    )]
    [IsoId("_nVvkUQx6Eeqdx6buGpCCQw")]
    [DisplayName("Card Payment Data Set Transaction 8 Choice")]
    public abstract record CardPaymentDataSetTransaction8Choice_ { }
}
