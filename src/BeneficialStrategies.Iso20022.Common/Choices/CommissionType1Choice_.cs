// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between a code or a data source scheme to determine the commission type.
    /// </summary>
    [KnownType(typeof(CommissionType1Choice.Code))]
    [KnownType(typeof(CommissionType1Choice.Proprietary))]
    [JsonDerivedType(typeof(CommissionType1Choice.Code),nameof(CommissionType1Choice.Code))]
    [JsonDerivedType(typeof(CommissionType1Choice.Proprietary),nameof(CommissionType1Choice.Proprietary))]
    [IsoId("_Q-K2dtp-Ed-ak6NoX_4Aeg_-2112435236")]
    [DisplayName("Commission Type 1 Choice")]
    public abstract partial record CommissionType1Choice_
    {
    }
}
