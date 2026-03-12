// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the Foreign Account Tax Compliance Act (FATCA) status.
    /// </summary>
    [KnownType(typeof(FATCAStatus1Choice.Code))]
    [KnownType(typeof(FATCAStatus1Choice.Proprietary))]
    [JsonDerivedType(typeof(FATCAStatus1Choice.Code),nameof(FATCAStatus1Choice.Code))]
    [JsonDerivedType(typeof(FATCAStatus1Choice.Proprietary),nameof(FATCAStatus1Choice.Proprietary))]
    [IsoId("_1dp7UQjREeS5F6qHcKOrew")]
    [DisplayName("FATCA Status 1 Choice")]
    public abstract partial record FATCAStatus1Choice_
    {
    }
}
