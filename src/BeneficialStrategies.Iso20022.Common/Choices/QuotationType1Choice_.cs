// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of quotation
    /// </summary>
    [KnownType(typeof(QuotationType1Choice.Code))]
    [KnownType(typeof(QuotationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(QuotationType1Choice.Code), nameof(QuotationType1Choice.Code))]
    [JsonDerivedType(
        typeof(QuotationType1Choice.Proprietary),
        nameof(QuotationType1Choice.Proprietary)
    )]
    [IsoId("_QPU_sNK4EeihtcVwfFPNlg")]
    [DisplayName("Quotation Type 1 Choice")]
    public abstract record QuotationType1Choice_ { }
}
