// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between the different statuses of a corporate action information advice.
    /// </summary>
    [KnownType(typeof(CorporateActionInformationStatus1Choice.ProcessedStatus))]
    [KnownType(typeof(CorporateActionInformationStatus1Choice.RejectedStatus))]
    [JsonDerivedType(
        typeof(CorporateActionInformationStatus1Choice.ProcessedStatus),
        nameof(CorporateActionInformationStatus1Choice.ProcessedStatus)
    )]
    [JsonDerivedType(
        typeof(CorporateActionInformationStatus1Choice.RejectedStatus),
        nameof(CorporateActionInformationStatus1Choice.RejectedStatus)
    )]
    [IsoId("_RiPM0tp-Ed-ak6NoX_4Aeg_-923033281")]
    [DisplayName("Corporate Action Information Status 1 Choice")]
    public abstract record CorporateActionInformationStatus1Choice_ { }
}
