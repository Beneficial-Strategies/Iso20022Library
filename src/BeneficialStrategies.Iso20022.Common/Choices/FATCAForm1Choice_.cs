// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the type of Foreign Account Tax Compliance Act (FATCA) form.
    /// </summary>
    [KnownType(typeof(FATCAForm1Choice.Code))]
    [KnownType(typeof(FATCAForm1Choice.Proprietary))]
    [JsonDerivedType(typeof(FATCAForm1Choice.Code),nameof(FATCAForm1Choice.Code))]
    [JsonDerivedType(typeof(FATCAForm1Choice.Proprietary),nameof(FATCAForm1Choice.Proprietary))]
    [IsoId("_blPakQjLEeS5F6qHcKOrew")]
    [DisplayName("FATCA Form 1 Choice")]
    public abstract partial record FATCAForm1Choice_
    {
    }
}
