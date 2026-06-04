// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using BeneficialStrategies.Iso20022.Choices.Status42Choice;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>Choice of format for an order cancellation status report.</summary>
    [IsoId("fe0d7a73-3cb0-457e-963c-4f0e5a6e7986")]
    [DisplayName("Status 42 Choice")]
    [KnownType(typeof(Status42Choice.CancellationStatusReport))]
    [KnownType(typeof(Status42Choice.IndividualCancellationStatusReport))]
    [JsonDerivedType(typeof(Status42Choice.CancellationStatusReport))]
    [JsonDerivedType(typeof(Status42Choice.IndividualCancellationStatusReport))]
    public abstract record Status42Choice_
    {
    }
}
