// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies whether the status is provided with a reason or not.
    /// </summary>
    [KnownType(typeof(DeniedStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(DeniedStatus1Choice.Reason))]
    [JsonDerivedType(
        typeof(DeniedStatus1Choice.NoSpecifiedReason),
        nameof(DeniedStatus1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(typeof(DeniedStatus1Choice.Reason), nameof(DeniedStatus1Choice.Reason))]
    [IsoId("_UWPlgtp-Ed-ak6NoX_4Aeg_309427241")]
    [DisplayName("Denied Status 1 Choice")]
    public abstract record DeniedStatus1Choice_ { }
}
