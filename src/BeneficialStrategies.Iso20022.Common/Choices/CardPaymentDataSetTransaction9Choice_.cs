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
    [KnownType(typeof(CardPaymentDataSetTransaction9Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction9Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction9Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction9Choice.AuthorisationResponse))]
    [KnownType(typeof(CardPaymentDataSetTransaction9Choice.TokenRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction9Choice.TokenResponse))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction9Choice.Completion),nameof(CardPaymentDataSetTransaction9Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction9Choice.Cancellation),nameof(CardPaymentDataSetTransaction9Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction9Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction9Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction9Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction9Choice.AuthorisationResponse))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction9Choice.TokenRequest),nameof(CardPaymentDataSetTransaction9Choice.TokenRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction9Choice.TokenResponse),nameof(CardPaymentDataSetTransaction9Choice.TokenResponse))]
    #endif
    [IsoId("_KJfv0S5BEeunNvJlR_vCbg")]
    [DisplayName("Card Payment Data Set Transaction 9 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardPaymentDataSetTransaction9Choice_
    #else
    public abstract partial class CardPaymentDataSetTransaction9Choice_
    #endif
    {
    }
}
