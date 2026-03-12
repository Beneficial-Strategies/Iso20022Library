// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a confirmation type.
    /// </summary>
    [KnownType(typeof(ConfirmationType1Choice.Code))]
    [KnownType(typeof(ConfirmationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ConfirmationType1Choice.Code),nameof(ConfirmationType1Choice.Code))]
    [JsonDerivedType(typeof(ConfirmationType1Choice.Proprietary),nameof(ConfirmationType1Choice.Proprietary))]
    [IsoId("_kY3MAEzLEeafiMTDrtSnyw")]
    [DisplayName("Confirmation Type 1 Choice")]
    public abstract partial record ConfirmationType1Choice_
    {
    }
}
