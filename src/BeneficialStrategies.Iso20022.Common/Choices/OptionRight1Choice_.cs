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
    [KnownType(typeof(OptionRight1Choice.Code))]
    [KnownType(typeof(OptionRight1Choice.Proprietary))]
    #if NET7_0_OR_GREATER // C# 11 Records, required members
    [JsonDerivedType(typeof(OptionRight1Choice.Code),nameof(OptionRight1Choice.Code))]
    [JsonDerivedType(typeof(OptionRight1Choice.Proprietary),nameof(OptionRight1Choice.Proprietary))]
    #endif
    [IsoId("_AeoSNdokEeC60axPepSq7g_-1501938465")]
    [DisplayName("Option Right 1 Choice")]
    #if DECLARE_SERIALIZABLE
    [Serializable]
    #endif
    #if DECLARE_DATACONTRACT
    [DataContract]
    #endif
    #if NET5_0_OR_GREATER // C# 9 Records, init-only setters, data annotations native
    public abstract partial record OptionRight1Choice_
    #else
    public abstract partial class OptionRight1Choice_
    #endif
    {
    }
}
