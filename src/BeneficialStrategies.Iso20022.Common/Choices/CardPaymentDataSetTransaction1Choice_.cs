// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction1Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction1Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction1Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction1Choice.AuthorisationResponse))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction1Choice.Completion),nameof(CardPaymentDataSetTransaction1Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction1Choice.Cancellation),nameof(CardPaymentDataSetTransaction1Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction1Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction1Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction1Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction1Choice.AuthorisationResponse))]
    [IsoId("_nxVGUC8QEeKW5usMQLtzqw")]
    [DisplayName("Card Payment Data Set Transaction 1 Choice")]
    public abstract partial record CardPaymentDataSetTransaction1Choice_
    {
    }
}
