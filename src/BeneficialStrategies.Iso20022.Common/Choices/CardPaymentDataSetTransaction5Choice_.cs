// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction5Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction5Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction5Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction5Choice.AuthorisationResponse))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction5Choice.Completion),nameof(CardPaymentDataSetTransaction5Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction5Choice.Cancellation),nameof(CardPaymentDataSetTransaction5Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction5Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction5Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction5Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction5Choice.AuthorisationResponse))]
    [IsoId("_CRbUIap3EeanIZ10Ka8PnA")]
    [DisplayName("Card Payment Data Set Transaction 5 Choice")]
    public abstract partial record CardPaymentDataSetTransaction5Choice_
    {
    }
}
