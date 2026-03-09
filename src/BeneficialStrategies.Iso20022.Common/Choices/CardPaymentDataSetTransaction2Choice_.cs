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
    [KnownType(typeof(CardPaymentDataSetTransaction2Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction2Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction2Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction2Choice.AuthorisationResponse))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction2Choice.Completion),nameof(CardPaymentDataSetTransaction2Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction2Choice.Cancellation),nameof(CardPaymentDataSetTransaction2Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction2Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction2Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction2Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction2Choice.AuthorisationResponse))]
    #endif
    [IsoId("_RAjlgTKQEeOqyZqt0rCZLg")]
    [DisplayName("Card Payment Data Set Transaction 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardPaymentDataSetTransaction2Choice_
    #else
    public abstract partial class CardPaymentDataSetTransaction2Choice_
    #endif
    {
    }
}
