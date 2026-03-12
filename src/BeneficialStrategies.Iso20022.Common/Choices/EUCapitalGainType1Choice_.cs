// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of an EU capital gain type.
    /// </summary>
    [KnownType(typeof(EUCapitalGainType1Choice.EUCapitalGain))]
    [KnownType(typeof(EUCapitalGainType1Choice.Proprietary))]
    [JsonDerivedType(typeof(EUCapitalGainType1Choice.EUCapitalGain),nameof(EUCapitalGainType1Choice.EUCapitalGain))]
    [JsonDerivedType(typeof(EUCapitalGainType1Choice.Proprietary),nameof(EUCapitalGainType1Choice.Proprietary))]
    [IsoId("_RgcdFdp-Ed-ak6NoX_4Aeg_-2050790406")]
    [DisplayName("EU Capital Gain Type 1 Choice")]
    public abstract partial record EUCapitalGainType1Choice_
    {
    }
}
