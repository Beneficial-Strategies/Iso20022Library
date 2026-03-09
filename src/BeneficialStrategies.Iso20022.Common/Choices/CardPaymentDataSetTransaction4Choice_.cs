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
    [KnownType(typeof(CardPaymentDataSetTransaction4Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction4Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction4Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction4Choice.AuthorisationResponse))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction4Choice.Completion),nameof(CardPaymentDataSetTransaction4Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction4Choice.Cancellation),nameof(CardPaymentDataSetTransaction4Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction4Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction4Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction4Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction4Choice.AuthorisationResponse))]
    #endif
    [IsoId("_Uop6gY3MEeWjkqXgn_0Imw")]
    [DisplayName("Card Payment Data Set Transaction 4 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardPaymentDataSetTransaction4Choice_
    #else
    public abstract partial class CardPaymentDataSetTransaction4Choice_
    #endif
    {
    }
}
