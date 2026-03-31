// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice defining financial instruments that are either new or have been modified.
    /// </summary>
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport2Choice.ModifiedRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport2Choice.NewRecord))]
    [KnownType(typeof(SecuritiesReferenceDeltaStatusReport2Choice.TerminatedRecord))]
    [JsonDerivedType(
        typeof(SecuritiesReferenceDeltaStatusReport2Choice.ModifiedRecord),
        nameof(SecuritiesReferenceDeltaStatusReport2Choice.ModifiedRecord)
    )]
    [JsonDerivedType(
        typeof(SecuritiesReferenceDeltaStatusReport2Choice.NewRecord),
        nameof(SecuritiesReferenceDeltaStatusReport2Choice.NewRecord)
    )]
    [JsonDerivedType(
        typeof(SecuritiesReferenceDeltaStatusReport2Choice.TerminatedRecord),
        nameof(SecuritiesReferenceDeltaStatusReport2Choice.TerminatedRecord)
    )]
    [IsoId("_2XCW1Hv0EeanCNPcMT7sSg")]
    [DisplayName("Securities Reference Delta Status Report 2 Choice")]
    public abstract record SecuritiesReferenceDeltaStatusReport2Choice_ { }
}
