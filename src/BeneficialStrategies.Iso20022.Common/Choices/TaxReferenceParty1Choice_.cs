// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of party.
    /// </summary>
    [KnownType(typeof(TaxReferenceParty1Choice.Code))]
    [KnownType(typeof(TaxReferenceParty1Choice.Proprietary))]
    [JsonDerivedType(typeof(TaxReferenceParty1Choice.Code),nameof(TaxReferenceParty1Choice.Code))]
    [JsonDerivedType(typeof(TaxReferenceParty1Choice.Proprietary),nameof(TaxReferenceParty1Choice.Proprietary))]
    [IsoId("_6PWX4E4REeiQHa-q1Uephw")]
    [DisplayName("Tax Reference Party 1 Choice")]
    public abstract partial record TaxReferenceParty1Choice_
    {
    }
}
