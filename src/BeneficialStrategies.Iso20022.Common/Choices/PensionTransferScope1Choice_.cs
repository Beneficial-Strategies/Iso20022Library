// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the scope of a pension transfer.
    /// </summary>
    [KnownType(typeof(PensionTransferScope1Choice.Code))]
    [KnownType(typeof(PensionTransferScope1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PensionTransferScope1Choice.Code),
        nameof(PensionTransferScope1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PensionTransferScope1Choice.Proprietary),
        nameof(PensionTransferScope1Choice.Proprietary)
    )]
    [IsoId("_REBa0E4YEeiQHa-q1Uephw")]
    [DisplayName("Pension Transfer Scope 1 Choice")]
    public abstract record PensionTransferScope1Choice_ { }
}
