// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Identifies a name of the identification scheme.
    /// </summary>
    [KnownType(typeof(ValidationRuleSchemeName1Choice.Code))]
    [KnownType(typeof(ValidationRuleSchemeName1Choice.Proprietary))]
    [JsonDerivedType(typeof(ValidationRuleSchemeName1Choice.Code),nameof(ValidationRuleSchemeName1Choice.Code))]
    [JsonDerivedType(typeof(ValidationRuleSchemeName1Choice.Proprietary),nameof(ValidationRuleSchemeName1Choice.Proprietary))]
    [IsoId("_kAjWY9jGEeSD0e0ybx5L5Q")]
    [DisplayName("Validation Rule Scheme Name 1 Choice")]
    public abstract partial record ValidationRuleSchemeName1Choice_
    {
    }
}
