// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice defining financial instruments that are either new or have been modified.
    /// </summary>
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport5Choice.ModifiedRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport5Choice.NewRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport5Choice.TerminatedRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport5Choice.CancelledRecord))]
    [JsonDerivedType(
        typeof(SecuritiesReferenceDeltaStatusReport5Choice.ModifiedRecord),
        nameof(SecuritiesReferenceDeltaStatusReport5Choice.ModifiedRecord)
    )]
    [JsonDerivedType(
        typeof(SecuritiesReferenceDeltaStatusReport5Choice.NewRecord),
        nameof(SecuritiesReferenceDeltaStatusReport5Choice.NewRecord)
    )]
    [JsonDerivedType(
        typeof(SecuritiesReferenceDeltaStatusReport5Choice.TerminatedRecord),
        nameof(SecuritiesReferenceDeltaStatusReport5Choice.TerminatedRecord)
    )]
    [JsonDerivedType(
        typeof(SecuritiesReferenceDeltaStatusReport5Choice.CancelledRecord),
        nameof(SecuritiesReferenceDeltaStatusReport5Choice.CancelledRecord)
    )]
    [IsoId("_ozgJwaWvEeqZmriXpMtonA")]
    [DisplayName("Securities Reference Delta Status Report 5 Choice")]
    public abstract record SecuritiesReferenceDeltaStatusReport5Choice_ { }
}
