// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of cancellation processing status.
    /// </summary>
    [KnownType(typeof(CancellationProcessingStatus1Choice.Code))]
    [KnownType(typeof(CancellationProcessingStatus1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CancellationProcessingStatus1Choice.Code),
        nameof(CancellationProcessingStatus1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CancellationProcessingStatus1Choice.Proprietary),
        nameof(CancellationProcessingStatus1Choice.Proprietary)
    )]
    [IsoId("_UX39Mtp-Ed-ak6NoX_4Aeg_-1853143805")]
    [DisplayName("Cancellation Processing Status 1 Choice")]
    public abstract record CancellationProcessingStatus1Choice_ { }
}
