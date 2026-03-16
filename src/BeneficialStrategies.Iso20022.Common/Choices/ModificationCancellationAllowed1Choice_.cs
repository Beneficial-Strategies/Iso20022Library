// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the ModificationCancellation information.
    /// </summary>
    [KnownType(typeof(ModificationCancellationAllowed1Choice.Indicator))]
    [KnownType(typeof(ModificationCancellationAllowed1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(ModificationCancellationAllowed1Choice.Indicator),
        nameof(ModificationCancellationAllowed1Choice.Indicator)
    )]
    [JsonDerivedType(
        typeof(ModificationCancellationAllowed1Choice.Proprietary),
        nameof(ModificationCancellationAllowed1Choice.Proprietary)
    )]
    [IsoId("_Qt7bAtp-Ed-ak6NoX_4Aeg_2048027430")]
    [DisplayName("Modification Cancellation Allowed 1 Choice")]
    public abstract record ModificationCancellationAllowed1Choice_ { }
}
