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
    /// Choice between a standard code and a proprietary code to specify the features that may apply to a corporate action option.
    /// </summary>
    [KnownType(typeof(OptionFeaturesFormat27Choice.Code))]
    [KnownType(typeof(OptionFeaturesFormat27Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionFeaturesFormat27Choice.Code),nameof(OptionFeaturesFormat27Choice.Code))]
    [JsonDerivedType(typeof(OptionFeaturesFormat27Choice.Proprietary),nameof(OptionFeaturesFormat27Choice.Proprietary))]
    #endif
    [IsoId("_732uofyYEeiKOe8GCUL1Lg")]
    [DisplayName("Option Features Format 27 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionFeaturesFormat27Choice_
    #else
    public abstract partial class OptionFeaturesFormat27Choice_
    #endif
    {
    }
}
