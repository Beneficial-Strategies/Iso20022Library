// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of investment account.
    /// </summary>
    [KnownType(typeof(GeneralInvestmentAccountType2Choice.Code))]
    [KnownType(typeof(GeneralInvestmentAccountType2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(GeneralInvestmentAccountType2Choice.Code),
        nameof(GeneralInvestmentAccountType2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(GeneralInvestmentAccountType2Choice.Proprietary),
        nameof(GeneralInvestmentAccountType2Choice.Proprietary)
    )]
    [IsoId("_4CGG0ZNuEembCsVG-3f_AA")]
    [DisplayName("General Investment Account Type 2 Choice")]
    public abstract record GeneralInvestmentAccountType2Choice_ { }
}
