// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of SubBalance type.
    /// </summary>
    [KnownType(typeof(SubBalanceType1Choice.SubBalanceType))]
    [KnownType(typeof(SubBalanceType1Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceType1Choice.SubBalanceType),nameof(SubBalanceType1Choice.SubBalanceType))]
    [JsonDerivedType(typeof(SubBalanceType1Choice.Proprietary),nameof(SubBalanceType1Choice.Proprietary))]
    [IsoId("_QZ9WINp-Ed-ak6NoX_4Aeg_219927874")]
    [DisplayName("Sub Balance Type 1 Choice")]
    public abstract partial record SubBalanceType1Choice_
    {
    }
}
