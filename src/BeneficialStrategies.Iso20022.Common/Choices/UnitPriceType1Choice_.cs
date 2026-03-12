// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of unit price type.
    /// </summary>
    [KnownType(typeof(UnitPriceType1Choice.Type))]
    [KnownType(typeof(UnitPriceType1Choice.Proprietary))]
    [JsonDerivedType(typeof(UnitPriceType1Choice.Type),nameof(UnitPriceType1Choice.Type))]
    [JsonDerivedType(typeof(UnitPriceType1Choice.Proprietary),nameof(UnitPriceType1Choice.Proprietary))]
    [IsoId("_RfZ7Qtp-Ed-ak6NoX_4Aeg_911473235")]
    [DisplayName("Unit Price Type 1 Choice")]
    public abstract partial record UnitPriceType1Choice_
    {
    }
}
