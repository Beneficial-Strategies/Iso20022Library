// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a standard code or proprietary code to specify the type of the renounceable entitlement status.
    /// </summary>
    [KnownType(typeof(RenounceableEntitlementStatusTypeFormat1Choice.Code))]
    [KnownType(typeof(RenounceableEntitlementStatusTypeFormat1Choice.Proprietary))]
    [JsonDerivedType(typeof(RenounceableEntitlementStatusTypeFormat1Choice.Code),nameof(RenounceableEntitlementStatusTypeFormat1Choice.Code))]
    [JsonDerivedType(typeof(RenounceableEntitlementStatusTypeFormat1Choice.Proprietary),nameof(RenounceableEntitlementStatusTypeFormat1Choice.Proprietary))]
    [IsoId("_Q3dxhtp-Ed-ak6NoX_4Aeg_1417014637")]
    [DisplayName("Renounceable Entitlement Status Type Format 1 Choice")]
    public abstract partial record RenounceableEntitlementStatusTypeFormat1Choice_
    {
    }
}
