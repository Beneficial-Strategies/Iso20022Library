// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(RejectionStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(RejectionStatus1Choice.Reason))]
    [JsonDerivedType(typeof(RejectionStatus1Choice.NoSpecifiedReason),nameof(RejectionStatus1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(RejectionStatus1Choice.Reason),nameof(RejectionStatus1Choice.Reason))]
    [IsoId("_UVWNqtp-Ed-ak6NoX_4Aeg_-635891282")]
    [DisplayName("Rejection Status 1 Choice")]
    public abstract partial record RejectionStatus1Choice_
    {
    }
}
