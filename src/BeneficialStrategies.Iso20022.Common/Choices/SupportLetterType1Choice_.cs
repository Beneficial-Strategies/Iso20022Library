// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the type of supporting letter.
    /// </summary>
    [KnownType(typeof(SupportLetterType1Choice.Code))]
    [KnownType(typeof(SupportLetterType1Choice.Proprietary))]
    [JsonDerivedType(typeof(SupportLetterType1Choice.Code),nameof(SupportLetterType1Choice.Code))]
    [JsonDerivedType(typeof(SupportLetterType1Choice.Proprietary),nameof(SupportLetterType1Choice.Proprietary))]
    [IsoId("_l_Ug0LbxEeu9Cp6InX88Vw")]
    [DisplayName("Support Letter Type 1 Choice")]
    public abstract partial record SupportLetterType1Choice_
    {
    }
}
