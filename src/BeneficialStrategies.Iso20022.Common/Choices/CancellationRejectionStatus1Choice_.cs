// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of cancellation rejection status.
    /// </summary>
    [KnownType(typeof(CancellationRejectionStatus1Choice.Code))]
    [KnownType(typeof(CancellationRejectionStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(CancellationRejectionStatus1Choice.Code),nameof(CancellationRejectionStatus1Choice.Code))]
    [JsonDerivedType(typeof(CancellationRejectionStatus1Choice.Proprietary),nameof(CancellationRejectionStatus1Choice.Proprietary))]
    [IsoId("_RCfVyNp-Ed-ak6NoX_4Aeg_1555805639")]
    [DisplayName("Cancellation Rejection Status 1 Choice")]
    public abstract partial record CancellationRejectionStatus1Choice_
    {
    }
}
