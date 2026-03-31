// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Reason for the return of the transaction.
    /// </summary>
    [KnownType(typeof(ReturnReason1Choice.Code))]
    [KnownType(typeof(ReturnReason1Choice.Proprietary))]
    [JsonDerivedType(typeof(ReturnReason1Choice.Code), nameof(ReturnReason1Choice.Code))]
    [JsonDerivedType(
        typeof(ReturnReason1Choice.Proprietary),
        nameof(ReturnReason1Choice.Proprietary)
    )]
    [IsoId("_TOkLx9p-Ed-ak6NoX_4Aeg_191375004")]
    [DisplayName("Return Reason 1 Choice")]
    public abstract record ReturnReason1Choice_ { }
}
