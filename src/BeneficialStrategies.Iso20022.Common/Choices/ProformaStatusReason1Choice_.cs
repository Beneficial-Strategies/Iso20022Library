// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a proforma status reason.
    /// </summary>
    [KnownType(typeof(ProformaStatusReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(ProformaStatusReason1Choice.Reason))]
    [JsonDerivedType(
        typeof(ProformaStatusReason1Choice.NoSpecifiedReason),
        nameof(ProformaStatusReason1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(ProformaStatusReason1Choice.Reason),
        nameof(ProformaStatusReason1Choice.Reason)
    )]
    [IsoId("_4nJZUUzCEeafiMTDrtSnyw")]
    [DisplayName("Proforma Status Reason 1 Choice")]
    public abstract record ProformaStatusReason1Choice_ { }
}
