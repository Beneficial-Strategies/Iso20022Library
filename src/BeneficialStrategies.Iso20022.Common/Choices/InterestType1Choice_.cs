// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Interest type is expressed as a code or a text.
    /// </summary>
    [KnownType(typeof(InterestType1Choice.Code))]
    [KnownType(typeof(InterestType1Choice.Proprietary))]
    [JsonDerivedType(typeof(InterestType1Choice.Code),nameof(InterestType1Choice.Code))]
    [JsonDerivedType(typeof(InterestType1Choice.Proprietary),nameof(InterestType1Choice.Proprietary))]
    [IsoId("_SRnbVtp-Ed-ak6NoX_4Aeg_-822918144")]
    [DisplayName("Interest Type 1 Choice")]
    public abstract partial record InterestType1Choice_
    {
    }
}
