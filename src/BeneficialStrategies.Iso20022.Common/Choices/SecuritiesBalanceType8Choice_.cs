// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the balance type.
    /// </summary>
    [KnownType(typeof(SecuritiesBalanceType8Choice.Code))]
    [KnownType(typeof(SecuritiesBalanceType8Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesBalanceType8Choice.Code),nameof(SecuritiesBalanceType8Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesBalanceType8Choice.Proprietary),nameof(SecuritiesBalanceType8Choice.Proprietary))]
    [IsoId("_5NeNE5NLEeWGlc8L7oPDIg")]
    [DisplayName("Securities Balance Type 8 Choice")]
    public abstract partial record SecuritiesBalanceType8Choice_
    {
    }
}
