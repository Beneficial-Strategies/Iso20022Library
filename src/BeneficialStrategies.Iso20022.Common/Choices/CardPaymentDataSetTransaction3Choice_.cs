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
    [KnownType(typeof(CardPaymentDataSetTransaction3Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction3Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction3Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction3Choice.AuthorisationResponse))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction3Choice.Completion),nameof(CardPaymentDataSetTransaction3Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction3Choice.Cancellation),nameof(CardPaymentDataSetTransaction3Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction3Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction3Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction3Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction3Choice.AuthorisationResponse))]
    #endif
    [IsoId("_EmW5UWmJEeS7iYydEtv3Ug")]
    [DisplayName("Card Payment Data Set Transaction 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardPaymentDataSetTransaction3Choice_
    #else
    public abstract partial class CardPaymentDataSetTransaction3Choice_
    #endif
    {
    }
}
