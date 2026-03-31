// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the preference to income.
    /// </summary>
    [KnownType(typeof(PreferenceToIncome2Choice.Code))]
    [KnownType(typeof(PreferenceToIncome2Choice.Proprietary))]
    [JsonDerivedType(
        typeof(PreferenceToIncome2Choice.Code),
        nameof(PreferenceToIncome2Choice.Code)
    )]
    [JsonDerivedType(
        typeof(PreferenceToIncome2Choice.Proprietary),
        nameof(PreferenceToIncome2Choice.Proprietary)
    )]
    [IsoId("_Qu-j49p-Ed-ak6NoX_4Aeg_306435769")]
    [DisplayName("Preference To Income 2 Choice")]
    public abstract record PreferenceToIncome2Choice_ { }
}
