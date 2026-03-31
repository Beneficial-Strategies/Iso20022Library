// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of meeting type classification.
    /// </summary>
    [KnownType(typeof(MeetingTypeClassification1Choice.Code))]
    [KnownType(typeof(MeetingTypeClassification1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(MeetingTypeClassification1Choice.Code),
        nameof(MeetingTypeClassification1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(MeetingTypeClassification1Choice.Proprietary),
        nameof(MeetingTypeClassification1Choice.Proprietary)
    )]
    [IsoId("_RDrokNp-Ed-ak6NoX_4Aeg_843703595")]
    [DisplayName("Meeting Type Classification 1 Choice")]
    public abstract record MeetingTypeClassification1Choice_ { }
}
