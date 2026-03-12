// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities lending type.
    /// </summary>
    [KnownType(typeof(SecuritiesLendingType1Choice.Code))]
    [KnownType(typeof(SecuritiesLendingType1Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesLendingType1Choice.Code),nameof(SecuritiesLendingType1Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesLendingType1Choice.Proprietary),nameof(SecuritiesLendingType1Choice.Proprietary))]
    [IsoId("_AYXSItokEeC60axPepSq7g_-214940639")]
    [DisplayName("Securities Lending Type 1 Choice")]
    public abstract partial record SecuritiesLendingType1Choice_
    {
    }
}
