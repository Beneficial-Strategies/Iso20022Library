// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice between specification of the balance type in structured or free text format.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType1Choice.Structured))]
    [KnownType(typeof(SecuritiesBalanceType1Choice.Unstructured))]
    [JsonDerivedType(typeof(SecuritiesBalanceType1Choice.Structured),nameof(SecuritiesBalanceType1Choice.Structured))]
    [JsonDerivedType(typeof(SecuritiesBalanceType1Choice.Unstructured),nameof(SecuritiesBalanceType1Choice.Unstructured))]
    [IsoId("_U11Ehdp-Ed-ak6NoX_4Aeg_-710964651")]
    [DisplayName("Securities Balance Type 1 Choice")]
    public abstract partial record SecuritiesBalanceType1Choice_
    {
    }
}
