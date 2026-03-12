// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the system securities account type.
    /// </summary>
    [KnownType(typeof(SystemSecuritiesAccountType1Choice.Code))]
    [KnownType(typeof(SystemSecuritiesAccountType1Choice.Proprietary))]
    [JsonDerivedType(typeof(SystemSecuritiesAccountType1Choice.Code),nameof(SystemSecuritiesAccountType1Choice.Code))]
    [JsonDerivedType(typeof(SystemSecuritiesAccountType1Choice.Proprietary),nameof(SystemSecuritiesAccountType1Choice.Proprietary))]
    [IsoId("_bLDjYDp0Eemk2e6qGBk8IQ")]
    [DisplayName("System Securities Account Type 1 Choice")]
    public abstract partial record SystemSecuritiesAccountType1Choice_
    {
    }
}
