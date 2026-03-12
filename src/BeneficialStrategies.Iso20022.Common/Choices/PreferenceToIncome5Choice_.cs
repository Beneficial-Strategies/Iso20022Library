// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for Preference to income.
    /// </summary>
    [KnownType(typeof(PreferenceToIncome5Choice.Code))]
    [KnownType(typeof(PreferenceToIncome5Choice.Proprietary))]
    [JsonDerivedType(typeof(PreferenceToIncome5Choice.Code),nameof(PreferenceToIncome5Choice.Code))]
    [JsonDerivedType(typeof(PreferenceToIncome5Choice.Proprietary),nameof(PreferenceToIncome5Choice.Proprietary))]
    [IsoId("_4jwgS-LZEeWFtOV72FbX9w")]
    [DisplayName("Preference To Income 5 Choice")]
    public abstract partial record PreferenceToIncome5Choice_
    {
    }
}
