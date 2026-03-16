// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Additional Request Data1Choice.
    /// </summary>
    [KnownType(typeof(AdditionalRequestData1Choice.RequestedCompensation))]
    [KnownType(typeof(AdditionalRequestData1Choice.RequestedDebitAuthorisation))]
    [KnownType(typeof(AdditionalRequestData1Choice.RequestedValuation))]
    [KnownType(typeof(AdditionalRequestData1Choice.RequestNarrative))]
    [JsonDerivedType(typeof(AdditionalRequestData1Choice.RequestedCompensation),nameof(AdditionalRequestData1Choice.RequestedCompensation))]
    [JsonDerivedType(typeof(AdditionalRequestData1Choice.RequestedDebitAuthorisation),nameof(AdditionalRequestData1Choice.RequestedDebitAuthorisation))]
    [JsonDerivedType(typeof(AdditionalRequestData1Choice.RequestedValuation),nameof(AdditionalRequestData1Choice.RequestedValuation))]
    [JsonDerivedType(typeof(AdditionalRequestData1Choice.RequestNarrative),nameof(AdditionalRequestData1Choice.RequestNarrative))]
    [IsoId("_QnNBUHSHEe2bKJC9xIuWQw")]
    [DisplayName("Additional Request Data1Choice")]
    public abstract partial record AdditionalRequestData1Choice_
    {
    }
}
