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
    /// Choice of format for the FX Standing Instruction information.
    /// </summary>
    [KnownType(typeof(FXStandingInstruction3Choice.Indicator))]
    [KnownType(typeof(FXStandingInstruction3Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(FXStandingInstruction3Choice.Indicator),nameof(FXStandingInstruction3Choice.Indicator))]
    [JsonDerivedType(typeof(FXStandingInstruction3Choice.Proprietary),nameof(FXStandingInstruction3Choice.Proprietary))]
    #endif
    [IsoId("_Aamt1NokEeC60axPepSq7g_1602416385")]
    [DisplayName("FX Standing Instruction 3 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record FXStandingInstruction3Choice_
    #else
    public abstract partial class FXStandingInstruction3Choice_
    #endif
    {
    }
}
