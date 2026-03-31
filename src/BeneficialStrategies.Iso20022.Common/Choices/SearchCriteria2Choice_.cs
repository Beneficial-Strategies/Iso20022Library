// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Search Criteria2Choice.
    /// </summary>
    [KnownType(typeof(SearchCriteria2Choice.Account))]
    [KnownType(typeof(SearchCriteria2Choice.CustomerIdentification))]
    [KnownType(typeof(SearchCriteria2Choice.OriginalTransactionNumber))]
    [KnownType(typeof(SearchCriteria2Choice.PaymentInstrument))]
    [JsonDerivedType(typeof(SearchCriteria2Choice.Account), nameof(SearchCriteria2Choice.Account))]
    [JsonDerivedType(
        typeof(SearchCriteria2Choice.CustomerIdentification),
        nameof(SearchCriteria2Choice.CustomerIdentification)
    )]
    [JsonDerivedType(
        typeof(SearchCriteria2Choice.OriginalTransactionNumber),
        nameof(SearchCriteria2Choice.OriginalTransactionNumber)
    )]
    [JsonDerivedType(
        typeof(SearchCriteria2Choice.PaymentInstrument),
        nameof(SearchCriteria2Choice.PaymentInstrument)
    )]
    [IsoId("_8U6MN248EeiU9cctagi5ow")]
    [DisplayName("Search Criteria2Choice")]
    public abstract record SearchCriteria2Choice_ { }
}
