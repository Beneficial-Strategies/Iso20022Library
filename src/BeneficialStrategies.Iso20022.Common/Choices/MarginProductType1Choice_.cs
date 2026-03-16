// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Provides specification for the underlying product of the margin.
    /// </summary>
    [KnownType(typeof(MarginProductType1Choice.Code))]
    [KnownType(typeof(MarginProductType1Choice.Proprietary))]
    [JsonDerivedType(typeof(MarginProductType1Choice.Code), nameof(MarginProductType1Choice.Code))]
    [JsonDerivedType(
        typeof(MarginProductType1Choice.Proprietary),
        nameof(MarginProductType1Choice.Proprietary)
    )]
    [IsoId("_Qk_hdNp-Ed-ak6NoX_4Aeg_1848984262")]
    [DisplayName("Margin Product Type 1 Choice")]
    public abstract record MarginProductType1Choice_ { }
}
