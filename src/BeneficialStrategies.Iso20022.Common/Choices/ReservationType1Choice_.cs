// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Defines the type of action to be performed in the request.
    /// </summary>
    [KnownType(typeof(ReservationType1Choice.Code))]
    [KnownType(typeof(ReservationType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ReservationType1Choice.Code),nameof(ReservationType1Choice.Code))]
    [JsonDerivedType(typeof(ReservationType1Choice.Proprietary),nameof(ReservationType1Choice.Proprietary))]
    [IsoId("_8JKFEKMgEeCJ6YNENx4h-w_632867546")]
    [DisplayName("Reservation Type 1 Choice")]
    public abstract partial record ReservationType1Choice_
    {
    }
}
