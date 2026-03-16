// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Investigation Data Record1Choice.
    /// </summary>
    [KnownType(typeof(InvestigationDataRecord1Choice.Compensation))]
    [KnownType(typeof(InvestigationDataRecord1Choice.Confirmation))]
    [KnownType(typeof(InvestigationDataRecord1Choice.DebitAuthorisation))]
    [KnownType(typeof(InvestigationDataRecord1Choice.ResponseNarrative))]
    [KnownType(typeof(InvestigationDataRecord1Choice.TransactionData))]
    [KnownType(typeof(InvestigationDataRecord1Choice.TransactionStatus))]
    [KnownType(typeof(InvestigationDataRecord1Choice.Valuation))]
    [JsonDerivedType(typeof(InvestigationDataRecord1Choice.Compensation),nameof(InvestigationDataRecord1Choice.Compensation))]
    [JsonDerivedType(typeof(InvestigationDataRecord1Choice.Confirmation),nameof(InvestigationDataRecord1Choice.Confirmation))]
    [JsonDerivedType(typeof(InvestigationDataRecord1Choice.DebitAuthorisation),nameof(InvestigationDataRecord1Choice.DebitAuthorisation))]
    [JsonDerivedType(typeof(InvestigationDataRecord1Choice.ResponseNarrative),nameof(InvestigationDataRecord1Choice.ResponseNarrative))]
    [JsonDerivedType(typeof(InvestigationDataRecord1Choice.TransactionData),nameof(InvestigationDataRecord1Choice.TransactionData))]
    [JsonDerivedType(typeof(InvestigationDataRecord1Choice.TransactionStatus),nameof(InvestigationDataRecord1Choice.TransactionStatus))]
    [JsonDerivedType(typeof(InvestigationDataRecord1Choice.Valuation),nameof(InvestigationDataRecord1Choice.Valuation))]
    [IsoId("_CsX6JZrOEeyo0KtkyUQoRg")]
    [DisplayName("Investigation Data Record1Choice")]
    public abstract partial record InvestigationDataRecord1Choice_
    {
    }
}
