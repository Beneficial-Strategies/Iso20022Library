// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Used to report between the party reference data or an operational error.
    /// </summary>
    [KnownType(typeof(PartyAuditTrailOrError1Choice.PartyAuditTrailReport))]
    [KnownType(typeof(PartyAuditTrailOrError1Choice.OperationalError))]
    [JsonDerivedType(typeof(PartyAuditTrailOrError1Choice.PartyAuditTrailReport),nameof(PartyAuditTrailOrError1Choice.PartyAuditTrailReport))]
    [JsonDerivedType(typeof(PartyAuditTrailOrError1Choice.OperationalError),nameof(PartyAuditTrailOrError1Choice.OperationalError))]
    [IsoId("_QgdAwZ9uEee7Qpz45yWJJw")]
    [DisplayName("Party Audit Trail Or Error 1 Choice")]
    public abstract partial record PartyAuditTrailOrError1Choice_
    {
    }
}
