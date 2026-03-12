// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for applicable rules.
    /// </summary>
    [KnownType(typeof(ApplicableRules1Choice.Code))]
    [KnownType(typeof(ApplicableRules1Choice.Proprietary))]
    [JsonDerivedType(typeof(ApplicableRules1Choice.Code),nameof(ApplicableRules1Choice.Code))]
    [JsonDerivedType(typeof(ApplicableRules1Choice.Proprietary),nameof(ApplicableRules1Choice.Proprietary))]
    [IsoId("_pSYd0FNeEeijdq8ilaxyOA")]
    [DisplayName("Applicable Rules 1 Choice")]
    public abstract partial record ApplicableRules1Choice_
    {
    }
}
