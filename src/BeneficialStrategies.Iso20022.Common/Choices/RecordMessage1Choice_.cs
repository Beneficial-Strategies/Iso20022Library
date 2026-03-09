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
    /// Message to be sent in a batch transfer as a record.
    /// </summary>
    [KnownType(typeof(RecordMessage1Choice.AddendumInitiation))]
    [KnownType(typeof(RecordMessage1Choice.AddendumResponse))]
    [KnownType(typeof(RecordMessage1Choice.Amendment))]
    [KnownType(typeof(RecordMessage1Choice.AuthorisationInitiation))]
    [KnownType(typeof(RecordMessage1Choice.AuthorisationResponse))]
    [KnownType(typeof(RecordMessage1Choice.CardManagementInitiation))]
    [KnownType(typeof(RecordMessage1Choice.CardManagementResponse))]
    [KnownType(typeof(RecordMessage1Choice.ChargeBackInitiation))]
    [KnownType(typeof(RecordMessage1Choice.ChargeBackResponse))]
    [KnownType(typeof(RecordMessage1Choice.Error))]
    [KnownType(typeof(RecordMessage1Choice.FeeCollectionInitiation))]
    [KnownType(typeof(RecordMessage1Choice.FeeCollectionResponse))]
    [KnownType(typeof(RecordMessage1Choice.FileActionInitiation))]
    [KnownType(typeof(RecordMessage1Choice.FileActionResponse))]
    [KnownType(typeof(RecordMessage1Choice.FinancialInitiation))]
    [KnownType(typeof(RecordMessage1Choice.FinancialResponse))]
    [KnownType(typeof(RecordMessage1Choice.FraudDispositionInitiation))]
    [KnownType(typeof(RecordMessage1Choice.FraudDispositionResponse))]
    [KnownType(typeof(RecordMessage1Choice.FraudReportingInitiation))]
    [KnownType(typeof(RecordMessage1Choice.FraudReportingResponse))]
    [KnownType(typeof(RecordMessage1Choice.InquiryInitiation))]
    [KnownType(typeof(RecordMessage1Choice.InquiryResponse))]
    [KnownType(typeof(RecordMessage1Choice.KeyExchangeInitiation))]
    [KnownType(typeof(RecordMessage1Choice.KeyExchangeResponse))]
    [KnownType(typeof(RecordMessage1Choice.NetworkManagementInitiation))]
    [KnownType(typeof(RecordMessage1Choice.NetworkManagementResponse))]
    [KnownType(typeof(RecordMessage1Choice.ReconciliationInitiation))]
    [KnownType(typeof(RecordMessage1Choice.ReconciliationResponse))]
    [KnownType(typeof(RecordMessage1Choice.RetrievalInitiation))]
    [KnownType(typeof(RecordMessage1Choice.RetrievalResponse))]
    [KnownType(typeof(RecordMessage1Choice.RetrievalFulfilmentInitiation))]
    [KnownType(typeof(RecordMessage1Choice.RetrievalFulfilmentResponse))]
    [KnownType(typeof(RecordMessage1Choice.ReversalInitiation))]
    [KnownType(typeof(RecordMessage1Choice.ReversalResponse))]
    [KnownType(typeof(RecordMessage1Choice.SettlementReportingInitiation))]
    [KnownType(typeof(RecordMessage1Choice.SettlementReportingResponse))]
    [KnownType(typeof(RecordMessage1Choice.VerificationInitiation))]
    [KnownType(typeof(RecordMessage1Choice.VerificationResponse))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(RecordMessage1Choice.AddendumInitiation),nameof(RecordMessage1Choice.AddendumInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.AddendumResponse),nameof(RecordMessage1Choice.AddendumResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.Amendment),nameof(RecordMessage1Choice.Amendment))]
    [JsonDerivedType(typeof(RecordMessage1Choice.AuthorisationInitiation),nameof(RecordMessage1Choice.AuthorisationInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.AuthorisationResponse),nameof(RecordMessage1Choice.AuthorisationResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.CardManagementInitiation),nameof(RecordMessage1Choice.CardManagementInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.CardManagementResponse),nameof(RecordMessage1Choice.CardManagementResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.ChargeBackInitiation),nameof(RecordMessage1Choice.ChargeBackInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.ChargeBackResponse),nameof(RecordMessage1Choice.ChargeBackResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.Error),nameof(RecordMessage1Choice.Error))]
    [JsonDerivedType(typeof(RecordMessage1Choice.FeeCollectionInitiation),nameof(RecordMessage1Choice.FeeCollectionInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.FeeCollectionResponse),nameof(RecordMessage1Choice.FeeCollectionResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.FileActionInitiation),nameof(RecordMessage1Choice.FileActionInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.FileActionResponse),nameof(RecordMessage1Choice.FileActionResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.FinancialInitiation),nameof(RecordMessage1Choice.FinancialInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.FinancialResponse),nameof(RecordMessage1Choice.FinancialResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.FraudDispositionInitiation),nameof(RecordMessage1Choice.FraudDispositionInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.FraudDispositionResponse),nameof(RecordMessage1Choice.FraudDispositionResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.FraudReportingInitiation),nameof(RecordMessage1Choice.FraudReportingInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.FraudReportingResponse),nameof(RecordMessage1Choice.FraudReportingResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.InquiryInitiation),nameof(RecordMessage1Choice.InquiryInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.InquiryResponse),nameof(RecordMessage1Choice.InquiryResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.KeyExchangeInitiation),nameof(RecordMessage1Choice.KeyExchangeInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.KeyExchangeResponse),nameof(RecordMessage1Choice.KeyExchangeResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.NetworkManagementInitiation),nameof(RecordMessage1Choice.NetworkManagementInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.NetworkManagementResponse),nameof(RecordMessage1Choice.NetworkManagementResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.ReconciliationInitiation),nameof(RecordMessage1Choice.ReconciliationInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.ReconciliationResponse),nameof(RecordMessage1Choice.ReconciliationResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.RetrievalInitiation),nameof(RecordMessage1Choice.RetrievalInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.RetrievalResponse),nameof(RecordMessage1Choice.RetrievalResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.RetrievalFulfilmentInitiation),nameof(RecordMessage1Choice.RetrievalFulfilmentInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.RetrievalFulfilmentResponse),nameof(RecordMessage1Choice.RetrievalFulfilmentResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.ReversalInitiation),nameof(RecordMessage1Choice.ReversalInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.ReversalResponse),nameof(RecordMessage1Choice.ReversalResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.SettlementReportingInitiation),nameof(RecordMessage1Choice.SettlementReportingInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.SettlementReportingResponse),nameof(RecordMessage1Choice.SettlementReportingResponse))]
    [JsonDerivedType(typeof(RecordMessage1Choice.VerificationInitiation),nameof(RecordMessage1Choice.VerificationInitiation))]
    [JsonDerivedType(typeof(RecordMessage1Choice.VerificationResponse),nameof(RecordMessage1Choice.VerificationResponse))]
    #endif
    [IsoId("_F2jDAFZVEeen1vB4iz5SyA")]
    [DisplayName("Record Message 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record RecordMessage1Choice_
    #else
    public abstract partial class RecordMessage1Choice_
    #endif
    {
    }
}
