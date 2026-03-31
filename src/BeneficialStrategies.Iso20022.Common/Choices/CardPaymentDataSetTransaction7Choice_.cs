// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction7Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction7Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction7Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction7Choice.AuthorisationResponse))]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction7Choice.Completion),
        nameof(CardPaymentDataSetTransaction7Choice.Completion)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction7Choice.Cancellation),
        nameof(CardPaymentDataSetTransaction7Choice.Cancellation)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction7Choice.AuthorisationRequest),
        nameof(CardPaymentDataSetTransaction7Choice.AuthorisationRequest)
    )]
    [JsonDerivedType(
        typeof(CardPaymentDataSetTransaction7Choice.AuthorisationResponse),
        nameof(CardPaymentDataSetTransaction7Choice.AuthorisationResponse)
    )]
    [IsoId("_4uNvsdeiEeiJyp_aycJaTw")]
    [DisplayName("Card Payment Data Set Transaction 7 Choice")]
    public abstract record CardPaymentDataSetTransaction7Choice_ { }
}
