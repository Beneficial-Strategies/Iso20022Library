// Copyright 2026 Jeff Ward, Beneficial Strategies. Usage subject to license of enclosing library.

using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Linq;

#if NET6_0_OR_GREATER // C# 10 
#else
using System.DateOnly=System.DateTime; // So data types will degrade gracefully
using System.TimeOnly=System.DateTime; // Same with this data type
#endif
namespace BeneficialStrategies.Iso20022.Choices
{
    /// <summary>
    /// Choice of format for the preference to income.
    /// </summary>
    [KnownType(typeof(PreferenceToIncome2Choice.Code))]
    [KnownType(typeof(PreferenceToIncome2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(PreferenceToIncome2Choice.Code),nameof(PreferenceToIncome2Choice.Code))]
    [JsonDerivedType(typeof(PreferenceToIncome2Choice.Proprietary),nameof(PreferenceToIncome2Choice.Proprietary))]
    #endif
    [IsoId("_Qu-j49p-Ed-ak6NoX_4Aeg_306435769")]
    [DisplayName("Preference To Income 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record PreferenceToIncome2Choice_
    #else
    public abstract partial class PreferenceToIncome2Choice_
    #endif
    {
    }
}
