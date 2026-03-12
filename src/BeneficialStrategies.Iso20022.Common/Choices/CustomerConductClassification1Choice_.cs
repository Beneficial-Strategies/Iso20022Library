// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for the specification of the customer conduct classification.
    /// </summary>
    [KnownType(typeof(CustomerConductClassification1Choice.Code))]
    [KnownType(typeof(CustomerConductClassification1Choice.Proprietary))]
    [JsonDerivedType(typeof(CustomerConductClassification1Choice.Code),nameof(CustomerConductClassification1Choice.Code))]
    [JsonDerivedType(typeof(CustomerConductClassification1Choice.Proprietary),nameof(CustomerConductClassification1Choice.Proprietary))]
    [IsoId("_E0HGsxdwEeKYM7Bc71nDlA")]
    [DisplayName("Customer Conduct Classification 1 Choice")]
    public abstract partial record CustomerConductClassification1Choice_
    {
    }
}
