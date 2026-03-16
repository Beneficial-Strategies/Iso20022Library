// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the different statuses of an election advice.
    /// </summary>
    [KnownType(typeof(ElectionAdviceStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(ElectionAdviceStatus1Choice.RejectedStatus))]
    [JsonDerivedType(
        typeof(ElectionAdviceStatus1Choice.ProcessedStatus),
        nameof(ElectionAdviceStatus1Choice.ProcessedStatus)
    )]
    [JsonDerivedType(
        typeof(ElectionAdviceStatus1Choice.RejectedStatus),
        nameof(ElectionAdviceStatus1Choice.RejectedStatus)
    )]
    [IsoId("_RiYWxtp-Ed-ak6NoX_4Aeg_896505165")]
    [DisplayName("Election Advice Status 1 Choice")]
    public abstract record ElectionAdviceStatus1Choice_ { }
}
