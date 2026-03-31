// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of formats for a type of investment account.
    /// </summary>
    [KnownType(typeof(GeneralInvestmentAccountType1Choice.Code))]
    [KnownType(typeof(GeneralInvestmentAccountType1Choice.Proprietary))]
    [JsonDerivedType(
        typeof(GeneralInvestmentAccountType1Choice.Code),
        nameof(GeneralInvestmentAccountType1Choice.Code)
    )]
    [JsonDerivedType(
        typeof(GeneralInvestmentAccountType1Choice.Proprietary),
        nameof(GeneralInvestmentAccountType1Choice.Proprietary)
    )]
    [IsoId("_b9WV8F2cEeiFXdiLi_Nf4A")]
    [DisplayName("General Investment Account Type 1 Choice")]
    public abstract record GeneralInvestmentAccountType1Choice_ { }
}
