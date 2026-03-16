// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the different options to search for an account.
    /// </summary>
    [KnownType(typeof(AccountIdentificationSearchCriteria2Choice.Equal))]
    [KnownType(typeof(AccountIdentificationSearchCriteria2Choice.ContainText))]
    [KnownType(typeof(AccountIdentificationSearchCriteria2Choice.NotContainText))]
    [JsonDerivedType(
        typeof(AccountIdentificationSearchCriteria2Choice.Equal),
        nameof(AccountIdentificationSearchCriteria2Choice.Equal)
    )]
    [JsonDerivedType(
        typeof(AccountIdentificationSearchCriteria2Choice.ContainText),
        nameof(AccountIdentificationSearchCriteria2Choice.ContainText)
    )]
    [JsonDerivedType(
        typeof(AccountIdentificationSearchCriteria2Choice.NotContainText),
        nameof(AccountIdentificationSearchCriteria2Choice.NotContainText)
    )]
    [IsoId("_g7QEuGliEeGaMcKyqKNRfQ_-836272256")]
    [DisplayName("Account Identification Search Criteria 2 Choice")]
    public abstract record AccountIdentificationSearchCriteria2Choice_ { }
}
