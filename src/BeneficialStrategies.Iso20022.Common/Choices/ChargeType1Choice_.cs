// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Amount of money associated with a type of service.
    /// </summary>
    [KnownType(typeof(ChargeType1Choice.Type))]
    [KnownType(typeof(ChargeType1Choice.Proprietary))]
    [JsonDerivedType(typeof(ChargeType1Choice.Type),nameof(ChargeType1Choice.Type))]
    [JsonDerivedType(typeof(ChargeType1Choice.Proprietary),nameof(ChargeType1Choice.Proprietary))]
    [IsoId("_RhV09tp-Ed-ak6NoX_4Aeg_729960266")]
    [DisplayName("Charge Type 1 Choice")]
    public abstract partial record ChargeType1Choice_
    {
    }
}
