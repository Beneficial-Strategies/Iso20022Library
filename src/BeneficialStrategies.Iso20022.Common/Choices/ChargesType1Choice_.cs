// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Specifies the type of charges as a code or free text.
    /// </summary>
    [KnownType(typeof(ChargesType1Choice.Type))]
    [KnownType(typeof(ChargesType1Choice.OtherChargesType))]
    [JsonDerivedType(typeof(ChargesType1Choice.Type),nameof(ChargesType1Choice.Type))]
    [JsonDerivedType(typeof(ChargesType1Choice.OtherChargesType),nameof(ChargesType1Choice.OtherChargesType))]
    [IsoId("_nKgLABrdEeOVR9VN6fAMUg")]
    [DisplayName("Charges Type 1 Choice")]
    public abstract partial record ChargesType1Choice_
    {
    }
}
