// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction4Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction4Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction4Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction4Choice.AuthorisationResponse))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction4Choice.Completion),nameof(CardPaymentDataSetTransaction4Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction4Choice.Cancellation),nameof(CardPaymentDataSetTransaction4Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction4Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction4Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction4Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction4Choice.AuthorisationResponse))]
    [IsoId("_Uop6gY3MEeWjkqXgn_0Imw")]
    [DisplayName("Card Payment Data Set Transaction 4 Choice")]
    public abstract partial record CardPaymentDataSetTransaction4Choice_
    {
    }
}
