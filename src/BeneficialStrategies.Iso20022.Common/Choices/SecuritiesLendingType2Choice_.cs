// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the securities lending type.
    /// </summary>
    [KnownType(typeof(SecuritiesLendingType2Choice.Code))]
    [KnownType(typeof(SecuritiesLendingType2Choice.Proprietary))]
    [JsonDerivedType(typeof(SecuritiesLendingType2Choice.Code),nameof(SecuritiesLendingType2Choice.Code))]
    [JsonDerivedType(typeof(SecuritiesLendingType2Choice.Proprietary),nameof(SecuritiesLendingType2Choice.Proprietary))]
    [IsoId("_KZ4B0ZEkEeakHoV5BVecAQ")]
    [DisplayName("Securities Lending Type 2 Choice")]
    public abstract partial record SecuritiesLendingType2Choice_
    {
    }
}
