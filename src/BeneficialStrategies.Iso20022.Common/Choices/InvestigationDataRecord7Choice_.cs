// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Investigation Data Record7Choice.
    /// </summary>
    [KnownType(typeof(InvestigationDataRecord7Choice.Compensation))]
    [KnownType(typeof(InvestigationDataRecord7Choice.Confirmation))]
    [KnownType(typeof(InvestigationDataRecord7Choice.DebitAuthorisation))]
    [KnownType(typeof(InvestigationDataRecord7Choice.ResponseNarrative))]
    [KnownType(typeof(InvestigationDataRecord7Choice.TransactionData))]
    [KnownType(typeof(InvestigationDataRecord7Choice.TransactionStatus))]
    [KnownType(typeof(InvestigationDataRecord7Choice.Valuation))]
    [JsonDerivedType(
        typeof(InvestigationDataRecord7Choice.Compensation),
        nameof(InvestigationDataRecord7Choice.Compensation)
    )]
    [JsonDerivedType(
        typeof(InvestigationDataRecord7Choice.Confirmation),
        nameof(InvestigationDataRecord7Choice.Confirmation)
    )]
    [JsonDerivedType(
        typeof(InvestigationDataRecord7Choice.DebitAuthorisation),
        nameof(InvestigationDataRecord7Choice.DebitAuthorisation)
    )]
    [JsonDerivedType(
        typeof(InvestigationDataRecord7Choice.ResponseNarrative),
        nameof(InvestigationDataRecord7Choice.ResponseNarrative)
    )]
    [JsonDerivedType(
        typeof(InvestigationDataRecord7Choice.TransactionData),
        nameof(InvestigationDataRecord7Choice.TransactionData)
    )]
    [JsonDerivedType(
        typeof(InvestigationDataRecord7Choice.TransactionStatus),
        nameof(InvestigationDataRecord7Choice.TransactionStatus)
    )]
    [JsonDerivedType(
        typeof(InvestigationDataRecord7Choice.Valuation),
        nameof(InvestigationDataRecord7Choice.Valuation)
    )]
    [IsoId("_oax_8zrQEe-thIfLZ94a1w")]
    [DisplayName("Investigation Data Record7Choice")]
    public abstract record InvestigationDataRecord7Choice_ { }
}
