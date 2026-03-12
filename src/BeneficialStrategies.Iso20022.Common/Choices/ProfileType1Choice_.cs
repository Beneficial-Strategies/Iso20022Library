// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the profile type.
    /// </summary>
    [KnownType(typeof(ProfileType1Choice.Code))]
    [KnownType(typeof(ProfileType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ProfileType1Choice.Code),nameof(ProfileType1Choice.Code))]
    [JsonDerivedType(typeof(ProfileType1Choice.Proprietary),nameof(ProfileType1Choice.Proprietary))]
    [IsoId("_tXgbACDNEeWPMvNwVtiMsA")]
    [DisplayName("Profile Type 1 Choice")]
    public abstract partial record ProfileType1Choice_
    {
    }
}
