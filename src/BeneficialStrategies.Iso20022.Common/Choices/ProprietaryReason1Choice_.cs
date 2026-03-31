// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Proprietary identification of the reason related to a status.
    /// </summary>
    [KnownType(typeof(ProprietaryReason1Choice.NoSpecifiedReason))]
    [KnownType(typeof(ProprietaryReason1Choice.Reason))]
    [JsonDerivedType(
        typeof(ProprietaryReason1Choice.NoSpecifiedReason),
        nameof(ProprietaryReason1Choice.NoSpecifiedReason)
    )]
    [JsonDerivedType(
        typeof(ProprietaryReason1Choice.Reason),
        nameof(ProprietaryReason1Choice.Reason)
    )]
    [IsoId("_uoL4YVhFEeOMYfRGLS0NbA")]
    [DisplayName("Proprietary Reason 1 Choice")]
    public abstract record ProprietaryReason1Choice_ { }
}
