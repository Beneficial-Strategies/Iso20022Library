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
    /// Choice of format for the option rights.
    /// </summary>
    [KnownType(typeof(OptionRight2Choice.Code))]
    [KnownType(typeof(OptionRight2Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionRight2Choice.Code),nameof(OptionRight2Choice.Code))]
    [JsonDerivedType(typeof(OptionRight2Choice.Proprietary),nameof(OptionRight2Choice.Proprietary))]
    #endif
    [IsoId("_PwmrYZEjEeakHoV5BVecAQ")]
    [DisplayName("Option Right 2 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionRight2Choice_
    #else
    public abstract partial class OptionRight2Choice_
    #endif
    {
    }
}
