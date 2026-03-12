// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of SubBalance.
    /// </summary>
    [KnownType(typeof(SubBalanceType2Choice.SubBalanceType))]
    [KnownType(typeof(SubBalanceType2Choice.Proprietary))]
    [JsonDerivedType(typeof(SubBalanceType2Choice.SubBalanceType),nameof(SubBalanceType2Choice.SubBalanceType))]
    [JsonDerivedType(typeof(SubBalanceType2Choice.Proprietary),nameof(SubBalanceType2Choice.Proprietary))]
    [IsoId("_RgSsFdp-Ed-ak6NoX_4Aeg_-197756749")]
    [DisplayName("Sub Balance Type 2 Choice")]
    public abstract partial record SubBalanceType2Choice_
    {
    }
}
