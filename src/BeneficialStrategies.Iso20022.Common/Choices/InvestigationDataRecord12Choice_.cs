// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Specifies the data elements related to the response to an investigation request.</summary>
    [KnownType(typeof(InvestigationDataRecord12Choice.DebitAuthorisation))]
    [JsonDerivedType(typeof(InvestigationDataRecord12Choice.DebitAuthorisation), nameof(InvestigationDataRecord12Choice.DebitAuthorisation))]
    [KnownType(typeof(InvestigationDataRecord12Choice.Compensation))]
    [JsonDerivedType(typeof(InvestigationDataRecord12Choice.Compensation), nameof(InvestigationDataRecord12Choice.Compensation))]
    [KnownType(typeof(InvestigationDataRecord12Choice.Valuation))]
    [JsonDerivedType(typeof(InvestigationDataRecord12Choice.Valuation), nameof(InvestigationDataRecord12Choice.Valuation))]
    [KnownType(typeof(InvestigationDataRecord12Choice.Confirmation))]
    [JsonDerivedType(typeof(InvestigationDataRecord12Choice.Confirmation), nameof(InvestigationDataRecord12Choice.Confirmation))]
    [KnownType(typeof(InvestigationDataRecord12Choice.TransactionStatus))]
    [JsonDerivedType(typeof(InvestigationDataRecord12Choice.TransactionStatus), nameof(InvestigationDataRecord12Choice.TransactionStatus))]
    [KnownType(typeof(InvestigationDataRecord12Choice.TransactionData))]
    [JsonDerivedType(typeof(InvestigationDataRecord12Choice.TransactionData), nameof(InvestigationDataRecord12Choice.TransactionData))]
    [KnownType(typeof(InvestigationDataRecord12Choice.ResponseNarrative))]
    [JsonDerivedType(typeof(InvestigationDataRecord12Choice.ResponseNarrative), nameof(InvestigationDataRecord12Choice.ResponseNarrative))]
    [IsoId("16be93ac-0f22-4db6-ae8f-75981b183529")]
    [DisplayName("Investigation Data Record 12 Choice")]
    public abstract record InvestigationDataRecord12Choice_ { }
}
