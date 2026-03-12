// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of failing status.
    /// </summary>
    [KnownType(typeof(FailingStatus1Choice.NoSpecifiedReason))]
    [KnownType(typeof(FailingStatus1Choice.Reason))]
    [JsonDerivedType(typeof(FailingStatus1Choice.NoSpecifiedReason),nameof(FailingStatus1Choice.NoSpecifiedReason))]
    [JsonDerivedType(typeof(FailingStatus1Choice.Reason),nameof(FailingStatus1Choice.Reason))]
    [IsoId("_UZqs9tp-Ed-ak6NoX_4Aeg_1207630782")]
    [DisplayName("Failing Status 1 Choice")]
    public abstract partial record FailingStatus1Choice_
    {
    }
}
