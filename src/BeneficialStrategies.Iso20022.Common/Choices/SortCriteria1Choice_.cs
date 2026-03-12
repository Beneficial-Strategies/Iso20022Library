// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between pre-defined and user-defined sorting criteria.
    /// </summary>
    [KnownType(typeof(SortCriteria1Choice.Predefined))]
    [KnownType(typeof(SortCriteria1Choice.UserDefined))]
    [JsonDerivedType(typeof(SortCriteria1Choice.Predefined),nameof(SortCriteria1Choice.Predefined))]
    [JsonDerivedType(typeof(SortCriteria1Choice.UserDefined),nameof(SortCriteria1Choice.UserDefined))]
    [IsoId("_U1-1hNp-Ed-ak6NoX_4Aeg_1941564546")]
    [DisplayName("Sort Criteria 1 Choice")]
    public abstract partial record SortCriteria1Choice_
    {
    }
}
