// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType6Choice.Code))]
    [KnownType(typeof(SecuritiesBalanceType6Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesBalanceType6Choice.Code),nameof(SecuritiesBalanceType6Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesBalanceType6Choice.Proprietary),nameof(SecuritiesBalanceType6Choice.Proprietary))]
    [IsoId("_qYOkNTnsEeWfSKvvZlhRKg")]
    [DisplayName("Securities Balance Type 6 Choice")]
    public abstract partial record SecuritiesBalanceType6Choice_
    {
    }
}
