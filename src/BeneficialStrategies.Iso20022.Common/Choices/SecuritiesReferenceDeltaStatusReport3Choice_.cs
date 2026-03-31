// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice defining financial instruments that are either new or have been modified.
    /// </summary>
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport3Choice.ModifiedRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport3Choice.NewRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport3Choice.TerminatedRecord))]
    [JsonDerivedType(
        typeof(SecuritiesReferenceDeltaStatusReport3Choice.ModifiedRecord),
        nameof(SecuritiesReferenceDeltaStatusReport3Choice.ModifiedRecord)
    )]
    [JsonDerivedType(
        typeof(SecuritiesReferenceDeltaStatusReport3Choice.NewRecord),
        nameof(SecuritiesReferenceDeltaStatusReport3Choice.NewRecord)
    )]
    [JsonDerivedType(
        typeof(SecuritiesReferenceDeltaStatusReport3Choice.TerminatedRecord),
        nameof(SecuritiesReferenceDeltaStatusReport3Choice.TerminatedRecord)
    )]
    [IsoId("_PXSKkSdoEei12pGEsJIAeQ")]
    [DisplayName("Securities Reference Delta Status Report 3 Choice")]
    public abstract record SecuritiesReferenceDeltaStatusReport3Choice_ { }
}
