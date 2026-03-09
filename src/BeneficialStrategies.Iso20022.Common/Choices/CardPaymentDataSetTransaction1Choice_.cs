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
    [KnownType(typeof(CardPaymentDataSetTransaction1Choice.Completion))]
    [KnownType(typeof(CardPaymentDataSetTransaction1Choice.Cancellation))]
    [KnownType(typeof(CardPaymentDataSetTransaction1Choice.AuthorisationRequest))]
    [KnownType(typeof(CardPaymentDataSetTransaction1Choice.AuthorisationResponse))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction1Choice.Completion),nameof(CardPaymentDataSetTransaction1Choice.Completion))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction1Choice.Cancellation),nameof(CardPaymentDataSetTransaction1Choice.Cancellation))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction1Choice.AuthorisationRequest),nameof(CardPaymentDataSetTransaction1Choice.AuthorisationRequest))]
    [JsonDerivedType(typeof(CardPaymentDataSetTransaction1Choice.AuthorisationResponse),nameof(CardPaymentDataSetTransaction1Choice.AuthorisationResponse))]
    #endif
    [IsoId("_nxVGUC8QEeKW5usMQLtzqw")]
    [DisplayName("Card Payment Data Set Transaction 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record CardPaymentDataSetTransaction1Choice_
    #else
    public abstract partial class CardPaymentDataSetTransaction1Choice_
    #endif
    {
    }
}
