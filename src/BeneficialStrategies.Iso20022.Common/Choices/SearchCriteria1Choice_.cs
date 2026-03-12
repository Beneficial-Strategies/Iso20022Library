// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of search criteria for the financial investigation.
    /// </summary>
    [KnownType(typeof(SearchCriteria1Choice.Account))]
    [KnownType(typeof(SearchCriteria1Choice.CustomerIdentification))]
    [KnownType(typeof(SearchCriteria1Choice.PaymentInstrument))]
    [KnownType(typeof(SearchCriteria1Choice.OriginalTransactionNumber))]
    [JsonDerivedType(typeof(SearchCriteria1Choice.Account),nameof(SearchCriteria1Choice.Account))]
    [JsonDerivedType(typeof(SearchCriteria1Choice.CustomerIdentification),nameof(SearchCriteria1Choice.CustomerIdentification))]
    [JsonDerivedType(typeof(SearchCriteria1Choice.PaymentInstrument),nameof(SearchCriteria1Choice.PaymentInstrument))]
    [JsonDerivedType(typeof(SearchCriteria1Choice.OriginalTransactionNumber),nameof(SearchCriteria1Choice.OriginalTransactionNumber))]
    [IsoId("_sxyTUDv7EeGKuZXNQxGH3g")]
    [DisplayName("Search Criteria 1 Choice")]
    public abstract partial record SearchCriteria1Choice_
    {
    }
}
