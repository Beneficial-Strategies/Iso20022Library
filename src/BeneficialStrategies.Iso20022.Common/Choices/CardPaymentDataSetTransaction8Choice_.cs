// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Card payment transaction choice between cancellation, authorisation request and authorisation response.
    /// </summary>
    [KnownType(typeof(CardPaymentDataSetTransaction8Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction8Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction8Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction8Choice.AuthorisationResponse))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction8Choice.Completion),nameof(CardPaymentDataSetTransaction8Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction8Choice.Cancellation),nameof(CardPaymentDataSetTransaction8Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction8Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction8Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction8Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction8Choice.AuthorisationResponse))]
    #endif
    [IsoId("_nVvkUQx6Eeqdx6buGpCCQw")]
    [DisplayName("Card Payment Data Set Transaction 8 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardPaymentDataSetTransaction8Choice_
    #else
    public abstract partial class CardPaymentDataSetTransaction8Choice_
    #endif
    {
    }
}
