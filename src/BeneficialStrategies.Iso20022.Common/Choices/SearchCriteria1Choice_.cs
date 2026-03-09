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
    /// Choice of search criteria for the financial investigation.
    /// </summary>
    [KnownType(typeof(SearchCriteria1Choice.Account))]
    [KnownType(typeof(SearchCriteria1Choice.CustomerIdentification))]
    [KnownType(typeof(SearchCriteria1Choice.PaymentInstrument))]
    [KnownType(typeof(SearchCriteria1Choice.OriginalTransactionNumber))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(SearchCriteria1Choice.Account),nameof(SearchCriteria1Choice.Account))]
    [JsonDerivedType(typeof(SearchCriteria1Choice.CustomerIdentification),nameof(SearchCriteria1Choice.CustomerIdentification))]
    [JsonDerivedType(typeof(SearchCriteria1Choice.PaymentInstrument),nameof(SearchCriteria1Choice.PaymentInstrument))]
    [JsonDerivedType(typeof(SearchCriteria1Choice.OriginalTransactionNumber),nameof(SearchCriteria1Choice.OriginalTransactionNumber))]
    #endif
    [IsoId("_sxyTUDv7EeGKuZXNQxGH3g")]
    [DisplayName("Search Criteria 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record SearchCriteria1Choice_
    #else
    public abstract partial class SearchCriteria1Choice_
    #endif
    {
    }
}
