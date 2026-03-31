// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction6Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction6Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction6Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction6Choice.AuthorisationResponse))]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction6Choice.Completion),
        nameof(CardPaymentDataSetTransaction6Choice.Completion)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction6Choice.Cancellation),
        nameof(CardPaymentDataSetTransaction6Choice.Cancellation)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction6Choice.AuthorisationRequest),
        nameof(CardPaymentDataSetTransaction6Choice.AuthorisationRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction6Choice.AuthorisationResponse),
        nameof(CardPaymentDataSetTransaction6Choice.AuthorisationResponse)
    )]
    [IsoId("_Z5gHQdpoEeearpaEPXv9UA")]
    [DisplayName("Card Payment Data Set Transaction 6 Choice")]
    public abstract record CardPaymentDataSetTransaction6Choice_ { }
}
