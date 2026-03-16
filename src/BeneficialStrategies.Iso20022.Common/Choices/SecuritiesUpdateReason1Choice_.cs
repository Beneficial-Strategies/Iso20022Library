// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the reason for the update of securities.
    /// </summary>
    [KnownType(typeof(SecuritiesUpdateReason1Choice.Code))]
    [KnownType(typeof(SecuritiesUpdateReason1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(SecuritiesUpdateReason1Choice.Code),
        nameof(SecuritiesUpdateReason1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(SecuritiesUpdateReason1Choice.Proprietary),
        nameof(SecuritiesUpdateReason1Choice.Proprietary)
    )]
    [IsoId("_20ciUJI7EeuAlLVx8pyt3w")]
    [DisplayName("Securities Update Reason 1 Choice")]
    public abstract record SecuritiesUpdateReason1Choice_ { }
}
