// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction2Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction2Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction2Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction2Choice.AuthorisationResponse))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction2Choice.Completion),nameof(CardPaymentDataSetTransaction2Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction2Choice.Cancellation),nameof(CardPaymentDataSetTransaction2Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction2Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction2Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction2Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction2Choice.AuthorisationResponse))]
    [IsoId("_RAjlgTKQEeOqyZqt0rCZLg")]
    [DisplayName("Card Payment Data Set Transaction 2 Choice")]
    public abstract partial record CardPaymentDataSetTransaction2Choice_
    {
    }
}
