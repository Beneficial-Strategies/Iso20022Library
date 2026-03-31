// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the allegement status.
    /// </summary>
    [KnownType(typeof(AllegementStatus1Choice.Code))]
    [KnownType(typeof(AllegementStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(AllegementStatus1Choice.Code), nameof(AllegementStatus1Choice.Code))]
    [JsonDerivedType(
        typeof(AllegementStatus1Choice.Proprietary),
        nameof(AllegementStatus1Choice.Proprietary)
    )]
    [IsoId("_UakE0dp-Ed-ak6NoX_4Aeg_618404541")]
    [DisplayName("Allegement Status 1 Choice")]
    public abstract record AllegementStatus1Choice_ { }
}
