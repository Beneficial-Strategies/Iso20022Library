// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the reason for the reversal.
    /// </summary>
    [KnownType(typeof(CorporateActionReversalReason1Choice.Code))]
    [KnownType(typeof(CorporateActionReversalReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(CorporateActionReversalReason1Choice.Code),
        nameof(CorporateActionReversalReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(CorporateActionReversalReason1Choice.Proprietary),
        nameof(CorporateActionReversalReason1Choice.Proprietary)
    )]
    [IsoId("_QxDnhNp-Ed-ak6NoX_4Aeg_1723669606")]
    [DisplayName("Corporate Action Reversal Reason 1 Choice")]
    public abstract record CorporateActionReversalReason1Choice_ { }
}
